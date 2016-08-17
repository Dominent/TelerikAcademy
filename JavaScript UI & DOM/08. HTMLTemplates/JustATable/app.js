/// <reference path="Scripts/handlebars.min.js" />
/// <reference path="Scripts/jquery-3.1.0.min.js" />

const data = {
    headers: ['Vendor', 'Model', 'OS'],
    items: [
        {
            col1: 'Nokia',
            col2: 'Lumia 920',
            col3: 'Windows Phone'
        }, {
            col1: 'LG',
            col2: 'Nexus 5',
            col3: 'Android'
        }, {
            col1: 'Apple',
            col2: 'iPhone 6',
            col3: 'iOS'
        }]
};

function solve() {
    return function (selector) {

        var template =
            '<table class="items-table">' +
                '<thead>' +
                    '<tr> ' +
                        '<th>#</th>' +
                        '{{#headers}}' +
                            '<th>{{this}}</th>' +
                        '{{/headers}}' +
                    '</tr>' +
                '</thead>' +
            '<tbody>' +
                '{{#each items}}' +
                    '<tr>' +
                        '<td>{{@index}}</td>' +
                        '<td>{{this.col1}}</td> ' +
                        '<td>{{this.col2}}</td>' +
                        '<td>{{this.col3}}</td>' +
                    '</tr>' +
                '{{/each}}' +
            '</tbody>' +
        '</table>';

        //var output = document.getElementById(selector);

        //template = Handlebars.compile(template);
        //output.innerHTML = template(data);

        $(selector).html(template);
    }
}
