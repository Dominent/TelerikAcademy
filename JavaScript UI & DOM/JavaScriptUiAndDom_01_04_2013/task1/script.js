function createCalendar(selector, events) {
    const rows = 6;
    const colls = 7;

    function getLastDay(year, month) {
        return new Date(year, month + 1, 0).getDate();
    }

    var daysInWeek = ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday']

    function fillCalendar(container) {
        var table = document.createElement('table');
        var day = 1;
        var lastDay = getLastDay(2014, 5, 0)
        var startDayinWeek = 6;

        for (var i = 0; i < rows; i += 1) {
            var tr = document.createElement('tr');

            for (var k = 0; k < colls; k += 1) {
                var td = document.createElement('td');
                var header = document.createElement('div');
                var content = document.createElement('div');

                td.className = 'calendar-item'
                header.className = 'item-head';
                content.className = 'item-content';

                if (day <= lastDay) {
                    for (var z = 0; z < events.length; z += 1) {
                        if (events[z].date == day) {
                            content.innerText = 'hour: ' + events[z].hour + '\n' + events[z].title + '\n' + 'duration: ' + events[z].duration + 'min';
                        }
                    }
                    header.innerText = daysInWeek[startDayinWeek % 7] + ' ' + day + ' ' + 'June' + ' ' + '2014';
                    day += 1;
                    startDayinWeek += 1;
                }

                td.appendChild(header);
                td.appendChild(content);
                tr.appendChild(td);
            }
            table.appendChild(tr);
        }
        container.appendChild(table);
    }

    var container = document.querySelector(selector);
    fillCalendar(container);

    var picker = document.createElement('div');
    picker.className = 'datePicker';
    picker.style.display = 'none';

    var label = document.createElement('label');
    label.innerHTML = 'Add appointment: ';
    var input = document.createElement('input');
    input.type = 'text';
    input.id = 'appointment-input';
    var button = document.createElement('input');
    button.type = 'submit';
    input.id = 'appointment-submit';
    button.value = 'Add';

    label.appendChild(input);
    label.appendChild(button);

    picker.appendChild(label);

    var table = document.querySelector('#calendar-container > table');
    table.addEventListener('click', function (event) {
        if (!(event.target.querySelector('.datePicker'))) {
            picker.style.position = 'absolute';
            picker.style.left = event.clientX + 'px';
            picker.style.top = event.clientY + 'px';
            picker.style.zIndex = '200';
            picker.style.display = '';
             event.target.appendChild(picker);
        } else {
            event.target.removeChild(picker);
            picker.style.display = 'none';
        }
    })

    button.addEventListener('click', function (ev){
        console.log(input.value);
        var content = ev.target.parentElement.parentElement.parentElement;
        content.innerText = input.value;
    })
}