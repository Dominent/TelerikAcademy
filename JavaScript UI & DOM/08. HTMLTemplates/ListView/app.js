/// <reference path="Scripts/handlebars.min.js" />
/// <reference path="Scripts/jquery-3.1.0.min.js" />

function solve() {
    return function () {
        $.fn.listview = function (data) {
            var selector = 'data-template';
            var template = $('#' + this.attr(selector)).html();

            var output = handlebars.compile(template);

            for (var i = 0; i < data.length; i += 1) {
                this.append(output(data[i]));
            }

            return this;
        }
    }
}