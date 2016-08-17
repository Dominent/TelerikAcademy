/* globals document, window, console */

function solve() {
    return function (selector, initialSuggestions) {
        var container = document.querySelector(selector);
        var input = container.querySelector('.tb-pattern');
        var suggestionsList = container.querySelector('.suggestions-list');
        var btn = container.querySelector('.btn-add');
        var suggestionItem = document.createElement('li');
        suggestionItem.className = 'suggestion';
        suggestionItem.style.display = 'none';
        var aEl = document.createElement('a');
        aEl.className = 'suggestion-link';


        function getUniqueElements(list) {
            var arr = [];
            var result = list;

            for (var i = 0; i < list.length; i += 1) {
                if (arr.indexOf(list[i].toLowerCase()) != -1) {
                    result.splice(i, 1);
                } else {
                    arr.push(list[i].toLowerCase());
                }
            }

            return result;
        }

        if (initialSuggestions) {
            var uniqueSuggestions = getUniqueElements(initialSuggestions);
            addSuggestions();
        }

        function addSuggestions() {
            for (var i = 0; i < uniqueSuggestions.length; i += 1) {
                var temp = suggestionItem.cloneNode(true);
                var tempAEl = aEl.cloneNode(true);
                tempAEl.innerText = uniqueSuggestions[i];
                temp.appendChild(tempAEl);
                suggestionsList.appendChild(temp);
            }
        }

        var items = suggestionsList.querySelectorAll('.suggestion');
        input.addEventListener('input', function (ev) {
            var input = ev.target.value;
            if (input == '') {
                for (var i = 0; i < items.length; i += 1) {
                    {
                        items[i].style.display = 'none';
                    }
                }
            } else {
                var rgxExp = new RegExp(input, 'i')
                for (var i = 0; i < items.length; i += 1) {
                    var innerText = items[i].innerText;
                    if (innerText.match(rgxExp)) {
                        items[i].style.display = '';
                    } else {
                        items[i].style.display = 'none';
                    }
                }
            }

        })

        suggestionsList.addEventListener('click', function (ev) {
            if (ev.target.className === 'suggestion-link') {
                input.value = ev.target.innerText;

            }
        })


        btn.addEventListener('click', function (ev) {

            var temp = suggestionItem.cloneNode(true);
            var tempAEl = aEl.cloneNode(true);
            tempAEl.innerText = input.value;
            temp.appendChild(tempAEl);
            temp.style.display = '';

            var contains = false;
            for (var i = 0; i < items.length; i += 1) {
                if (items.innerText == input.value) {
                    contains = true;
                }
            }

            if (!contains)
                suggestionsList.appendChild(temp);

        })
    };
}

module.exports = solve;