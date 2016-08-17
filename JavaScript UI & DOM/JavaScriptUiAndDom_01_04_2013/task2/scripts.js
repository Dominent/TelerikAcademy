/// <reference path="typings/index.d.ts" />

$.fn.tabs = function () {
    function getIndex($tabItem) {
        return parseInt($tabItem.children('.tab-item-title').text().split(' ')[1]);
    }

    function showTab(target) {
        $tabItems.each(function (index, element) {
            var $this = $(this);
            var $index = getIndex($this);

            if ($index !== target) {
                $this.removeClass('current').children('.tab-item-content').hide();
            }else {
                $this.addClass('current').children('.tab-item-content').show();
            }
        })
    }
    
    var $tabsContainer = $('#tabs-container').addClass('tabs-container');
    var $tabItems = $tabsContainer.children('.tab-item');

    $tabItems.first().addClass('current');

    showTab(1);

    $tabItems.on('click', '.tab-item-title', function () {
        var $this = $(this);
        var $index = getIndex($this.parent());

        showTab($index);
    })
};