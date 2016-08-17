/// <reference path="../typings/index.d.ts" />

function solve() {
    $.fn.datepicker = function () {
        function getMonthString(input) {
            input = input % 11;
            var month = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];

            return month[input];
        }

        function getDaysOfMonth(year, month) {
            return new Date(year, month + 1, 0).getDate();
        }

        function updateCallendar(year, month) {
            var $datesTr = $calendar.children('tr');
            var day = 1;

            $datesTr.each(function (index, element) {
                if (index !== 0) { //thead
                    var $dates = $(element).children('td');
                    var endDay = getDaysOfMonth(year, month);
                    for (var i = 0; i < colls; i += 1) {
                        if (day <= endDay) {
                            $($dates[i]).text(day);
                            day += 1;
                        } else {
                            $dates.text('');
                        }
                    }
                }
            })
        }

        var $this = $(this);

        var $datePicker = $('#date').detach().addClass('datepicker');
        var $picker = $('<div />').addClass('picker');

        var $datePickerWrapper = $('<div />').addClass('datepicker-wrapper').append($datePicker, $picker);

        var $container = $('body').children('div').append($datePickerWrapper);

        $datePicker.on('click', function () {
            if ($picker.hasClass('picker-visible')) {
                $picker.removeClass('picker-visible');
            } else {
                $picker.addClass('picker-visible');
            }
        })

        var $controls = $('<div />').addClass('controls').appendTo($picker);

        var date = new Date();
        var controlsText = (getMonthString(parseInt(date.getMonth())) + ' ' + date.getFullYear());

        var $btnPrevious = $('<button />').addClass('btn btn-previous').appendTo($controls);
        var $divCurrentMonth = $('<div />').addClass('current-month').appendTo($controls);
        var $btnNext = $('<button />').addClass('btn btn-next').appendTo($controls);

        $divCurrentMonth.text(controlsText);

        var $calendar = $('<table />').addClass('calendar').appendTo($picker);

        // Su	Mo	Tu	We	Th	Fr	Sa    
        var tHeadArr = ['Su', 'Mo', 'Tu', 'We', 'Th', 'Fr', 'Sa'];
        var $tHeadRow = $('<tr />').appendTo($calendar);
        for (var i = 0; i < tHeadArr.length; i += 1) {
            $('<th />').text(tHeadArr[i]).appendTo($tHeadRow);
        }

        var rows = 6;
        var colls = 7;
        var day = 1;

        for (var i = 0; i < rows; i += 1) {
            var $tRow = $('<tr />');
            for (var k = 0; k < colls; k += 1) {
                if (day <= getDaysOfMonth(date.getFullYear(), date.getMonth())) {
                    ($('<td />').addClass('current-month')).text(day).appendTo($tRow);
                    day += 1;
                }
                else {
                    $tRow.append($('<td />').addClass('current-month'));
                }
            }
            $tRow.appendTo($calendar);
        }

        $btnNext.on('click', function () {
            date.setMonth(date.getMonth() + 1);
            updateCallendar(date.getFullYear(), date.getMonth());
            controlsText = (getMonthString(parseInt(date.getMonth())) + ' ' + date.getFullYear());
            $divCurrentMonth.text(controlsText);
        })

        var $currentDate = $('<div />').addClass('current-date').appendTo($picker);
        var $currentDateLink = $('<a />').addClass('current-date-link').text(date.getDate() + ' ' + controlsText).appendTo($currentDate);
    };
};

if (typeof module !== 'undefined') {
    module.exports = solve;
}