/// <reference path="../typings/index.d.ts" />

/* globals $ */

//function solve() {
$.fn.gallery = function (col) {

  function getNextIndex(index) {
    index += 1;
    if (index > $imageContainers.length) {
      index = 1;
    }
    return index;
  }

  function getPrevIndex(index) {
    index -= 1;
    if (index < 1) {
      index = $imageContainers.length;
    }
    return index;
  }

  function getImgByIndexAttr(index) {
    return $imageContainers.children("[data-info='" + (index) + "']");
  }

  function switchSrcAndData(element1, element2) {
    element1.attr('src', element2.attr('src'));
    element1.data('info', element2.data('info'));

    return this;
  }

  col = col || 4;

  var $gallery = $(this);
  var $galleryList = $gallery.children('.gallery-list');
  var $imageContainers = $galleryList.children('.image-container');
  var $selected = $gallery.children('.selected');
  var $currentImg = $selected.find('#current-image');
  var $nextImg = $selected.find('#next-image');
  var $prevImg = $selected.find('#previous-image');


  $imageContainers.each(function (index, element) {
    if (index % col === 0) {
      $(element).addClass('clearfix');
    }
  })

  $galleryList.on('click', 'img', function () {
    var $this = $(this);
    var $imgSrc = $this.attr('src');
    var $index = $this.data('info');
    $('<div />').addClass('disabled-background').appendTo($gallery);

    var $next = $imageContainers.children("[data-info='" + ($index + 1) + "']");
    var $prev = $imageContainers.children("[data-info='" + ($index - 1) + "']");

    $currentImg.attr('src', $imgSrc);
    $currentImg.attr('data-info', $index);

    $nextImg.attr('src', $next.attr('src'));
    $nextImg.attr('data-info', $index + 1);

    $prevImg.attr('src', $prev.attr('src'));
    $prevImg.attr('data-info', $index - 1);

    $galleryList.addClass('blurred');

    $selected.show();
  })

  $currentImg.on('click', function () {
    $galleryList.removeClass('blurred');

    $selected.hide();

    $gallery.children('.disabled-background').remove();
  })

  $nextImg.on('click', function () {
    var $this = $(this);
    var $index = $this.data('info');
    var $nextIndex = getNextIndex($index);
    var $next = getImgByIndexAttr($nextIndex);

    switchSrcAndData($prevImg, $currentImg);
    switchSrcAndData($currentImg, $this);
    switchSrcAndData($this, $next);
  
  })

   $prevImg.on('click', function () {
    var $this = $(this);
    var $index = $this.data('info');
    var $prevIndex = getPrevIndex($index);
    var $prev = getImgByIndexAttr($prevIndex);

    switchSrcAndData($nextImg, $currentImg);
    switchSrcAndData($currentImg, $this);
    switchSrcAndData($this, $prev);
  })

  $gallery.addClass('gallery');
  $selected.hide();

  return this;
};
//}
//module.exports = solve;