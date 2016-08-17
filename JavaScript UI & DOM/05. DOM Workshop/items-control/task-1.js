/// <reference path="../typings/index.d.ts" />

/* globals module, document, HTMLElement, console */

function solve () {
  return function (selector, isCaseSensitive) {
    // Adding elements
    function AddingElements () {
      var docFragment = document.createDocumentFragment()

      var divEl = document.createElement('div')
      divEl.className = 'add-controls'

      var inputEl = document.createElement('input')
      inputEl.type = 'text'

      var buttonEl = document.createElement('input')
      buttonEl.type = 'submit'
      buttonEl.value = 'Add'
      buttonEl.className = 'button'

      var labelEl = document.createElement('label')
      labelEl.innerHTML = 'Enter text: '

      labelEl.appendChild(inputEl)

      divEl.appendChild(labelEl)

      divEl.appendChild(buttonEl)

      docFragment.appendChild(divEl)

      document.body.appendChild(docFragment)
    };
    // End of Adding elements

    // Search elements
    function SearchElements () {
      var docFragment = document.createDocumentFragment()

      var divEl = document.createElement('div')
      divEl.className = 'search-controls'

      var inputEl = document.createElement('input')
      inputEl.type = 'text'

      var labelEl = document.createElement('label')
      labelEl.innerHTML = 'Search: '

      labelEl.appendChild(inputEl)

      divEl.appendChild(labelEl)

      docFragment.appendChild(divEl)

      document.body.appendChild(docFragment)
    }
    // End of Search elements

    // // Result elements
    function ResultElements () {
      var docFragment = document.createDocumentFragment()

      var divEl = document.createElement('div')
      divEl.className = 'result-controls'

      var ulEl = document.createElement('ul')
      ulEl.className = 'items-list'

      divEl.appendChild(ulEl)

      docFragment.appendChild(divEl)

      document.body.appendChild(docFragment)
    }
    // End of Result elements

    function OnAddingElement () {
      var element = document.querySelector('.result-controls > .items-list')
      var button = document.querySelector('.add-controls .button')

      var liEl = document.createElement('li')
      liEl.className = 'list-item'

      var buttonEl = document.createElement('input')
      buttonEl.type = 'button'
      buttonEl.value = 'X'
      buttonEl.className = 'button'

      liEl.appendChild(buttonEl)

      button.addEventListener('click', function (ev) {
        var input = document.querySelector('.add-controls > label > input[type="text"]')

        var currEl = liEl.cloneNode(true)

        currEl.innerHTML += input.value

        element.appendChild(currEl)
      })
    }

    function OnSearchElement (caseSensitive) {
      var input = document.querySelector('.search-controls > label > input[type="text"]')

      input.addEventListener('input', function () {
        var items = document.querySelectorAll('.list-item')

        for (var i = 0; i < items.length; i += 1) {
          var regExp = new RegExp(input.value, 'i')
          if (caseSensitive) {
            regExp = new RegExp(input.value)
          }

          if (items[i].innerText.match(regExp)) {
            console.log(items[i])
            items[i].style.display = ''
          } else {
            items[i].style.display = 'none'
          }
        }
      })
    }

    function OnResultElement () {
      var itemsList = document.querySelector('.items-list')

      itemsList.addEventListener('click', function (ev) {
        if (ev.target.className === 'button') {
          itemsList.removeChild(ev.target.parentNode)
        }
      })
    }

    AddingElements()
    SearchElements()
    ResultElements()

    OnAddingElement()
    OnSearchElement(true) // true -> case sensitive, false -> not case sensitive
    OnResultElement()
  }

  module.exports = solve
}

