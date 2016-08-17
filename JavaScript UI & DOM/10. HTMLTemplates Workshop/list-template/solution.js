/// <reference path="../typings/index.d.ts" />

function solve() {
    return function (selector) {


        var template =
        '{{#each authors}}' +
        '<div class="box {{#if this.right}}right{{/if}}">' +
            '<div class="inner">' +
                '<p>' +
                    '<img alt="{{this.name}}" src="{{this.image}}" width="100" height="133">' +
                '</p>' +
                '<div>' +
                    '<h3>{{this.name}}</h3>' +
                    '<p>Technical <b>Trainer</b></p>' +
                    '<ul>' +
                        '{{#each this.urls}}' +
                        '<li>' +
                            '<a href="{{this}}" target="_blank">{{this}}</a>' +
                        '</li>' +
                        '{{/each}}' +
                    '</ul>' +
                '</div>' +
             '</div>' +
        '</div>' +
        '{{/each}}';

        document.getElementById(selector).innerHTML = template;
    }
}

if(typeof module !== 'undefined') {
    module.exports = solve;
}