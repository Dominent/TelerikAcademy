function solve() {
    return function (selector) {
        var template = 
        '<div class="events-calendar">' +
        ' <h2 class="header">' +
            'Appointments for <span class="month">{{this.month}}</span> <span class="year">{{this.year}}</span>' +
        '</h2>' +
        '{{#each this.days}}' +
            '<div class="date">{{this.day}}</div>' +
            '<div class="events">' +
            '{{#each this.events}}' +
                '{{#if this.title}}' +
                    '<div class="event {{this.importance}}" title="{{this.comment}}">' +
                        '<div class="title">{{this.title}}</div>' +
                        '<span class="time">at: {{this.time}}</span>' +
                    '</div>' +
                '{{else}}' +
                    '<div class="event none">' +
                        '<div class="title">Free slot</div>' +
                    '</div>' +
                '{{/if}}' +
            '{{/each}}'+
            '</div>' +
        '{{/each}}';

        if(template.length) {
            document.getElementById(selector).innerHTML = template;
        }
    };
}

if (typeof module !== 'undefined') {
    module.exports = solve;
}