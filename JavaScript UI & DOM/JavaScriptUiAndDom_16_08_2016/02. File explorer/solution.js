/// <reference path="typings/index.d.ts" />

function solve() {
    return function (fileContentsByName) {
        var $fileExplorer = $('.file-explorer');
        var $filePreview = $('.file-preview');
        var $items = $fileExplorer.children('.items');
        var $fileContent = $filePreview.children('.file-content');
        var $addWrapper = $fileExplorer.children('.add-wrapper');
        var $addBtn = $addWrapper.children('.add-btn');
        var $input = $addWrapper.children('input');
        var $dir = $items.children('.dir-item')

        function generateItem(content) {
            var $container = $('<li />').addClass('file-item item');
            var $itemName = $('<a />').addClass('item-name').text(content);
            var $delBtn = $('<a />').addClass('del-btn');

            return $container.append($itemName, $delBtn);
        }

        $items.on('click', '.item-name', function () {
            var $this = $(this);
            var $parrent = $this.parent();
            if ($parrent.hasClass('dir-item item')) {
                if ($parrent.hasClass('collapsed')) {
                    $parrent.removeClass('collapsed');
                } else {
                    $parrent.addClass('collapsed');
                }
            } else {
                var fileName = $this.text();
                $fileContent.text(fileContentsByName[fileName]);
            }
        })

        $addBtn.on('click', function () {
            $addBtn.removeClass('visible');
            $input.addClass('visible');
        })

        $input.on('keydown', function (ev) {
            var $this = $(this);
            if (ev.keyCode == 13) {
                if ($this.val().includes('/')) {
                    var input = $this.val().split('/');
                    var dirName = input[0];
                    var itemName = input[1];
                    $dir.each(function (index, element) {
                        var $dirInnerText = $(element).children('.item-name').text();
                        if ($dirInnerText === dirName) {
                            var $dirItems = $(element).children('.items').append(generateItem(itemName))
                        }
                    })
                } else {
                    $items.append(generateItem($this.val()));
                }
                $this.val('');
                $addBtn.addClass('visible');
                $input.removeClass('visible');
            }
        })

        $items.on('click', '.del-btn', function() {
            var $this = $(this);
            $this.parent().remove();
        })
    }
}

if (typeof module !== 'undefined') {
    module.exports = solve;
}