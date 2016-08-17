/// <reference path="../typings/index.d.ts" />

/* globals module */
function solve() {
    return function (selector, items) {

        function swapSrc(element1, element2) {
            var tempSrc = element1.src;
            
            element1.src = element2.src;
            element2.src = tempSrc;
        }

        function swapText(element1, element2) {
            var tempText = element1.innerText;

            element1.innerText = element2.innerText;
            element2.innerText = tempText;
        }

        function addImgElements() {
            var container = document.querySelector(selector);

            var ulEl = document.createElement('ul');
            var liEl = document.createElement('li');
            var h2El = document.createElement('h2');
            var imgEl = document.createElement('img');
            var divEl = document.createElement('div');

            liEl.className = 'image-container';

            ulEl.style.width = '30%';
            ulEl.style.height = '500px';
            ulEl.style.cssFloat = 'right';
            ulEl.style.overflow = 'auto';

            var imagePreview = divEl;
            var imagePreviewTitle = h2El.cloneNode(true);
            var imagePreviewContent = imgEl.cloneNode(true);

            imagePreview.className = 'image-preview';
            imagePreview.style.cssFloat = 'left';
            imagePreview.style.width = '55%';

            imagePreviewTitle.innerText = items[0].title;
            imagePreviewContent.src = items[0].url;

            imagePreviewContent.style.width = '100%';
            imagePreviewContent.style.height = '100%';

            imagePreview.appendChild(imagePreviewTitle);
            imagePreview.appendChild(imagePreviewContent);

            for (var i = 0; i < items.length; i += 1) {
                var imageContainer = liEl.cloneNode(true);
                var imageContainerTitle = h2El.cloneNode(true);
                var imageContainerContent = imgEl.cloneNode(true);

                imageContainerTitle.innerText = items[i].title;
                imageContainerContent.src = items[i].url;

                imageContainerContent.style.width = '50%';
                imageContainerContent.style.height = '50%';

                imageContainer.appendChild(imageContainerTitle);
                imageContainer.appendChild(imageContainerContent);

                ulEl.appendChild(imageContainer);
            }

            container.appendChild(imagePreview);
            container.appendChild(ulEl);
        }

        function addFilterElements() {
            var container = document.querySelector(selector);

            var inputEl = document.createElement('input');
            var labelEl = document.createElement('label');

            inputEl.type = 'text';
            labelEl.innerHTML = 'Filter: ';
            labelEl.style.cssFloat = 'right';

            labelEl.appendChild(inputEl);

            container.appendChild(labelEl);
        }

        function onImgHover(selector) {
            var container = document.querySelector(selector);
            var color = '#d9d9d9';

            container.addEventListener('mouseover', function (ev) {
                if (ev.target.className === 'image-container') {
                    ev.target.style.background = color;
                } else if (ev.target.parentNode.className == 'image-container') {
                    ev.target.parentNode.style.background = color;
                }
            })

            container.addEventListener('mouseout', function (ev) {
                if (ev.target.className === 'image-container') {
                    ev.target.style.background = 'none';
                } else if (ev.target.parentNode.className == 'image-container') {
                    ev.target.parentNode.style.background = 'none';
                }
            })
        }

        function onImgClick(selector) {
            var container = document.querySelector(selector);
            var imagePreview = document.querySelector('.image-preview')

            container.addEventListener('click', function (ev) {
                if (ev.target.className === 'image-container') {
                    var element = ev.target;

                    swapSrc(element.querySelector('img'), imagePreview.querySelector('img'));
                    swapText(element.querySelector('h2'), imagePreview.querySelector('h2'));
                } else if (ev.target.parentNode.className == 'image-container') {
                    var element = ev.target.parentNode;
                  
                    swapSrc(element.querySelector('img'), imagePreview.querySelector('img'));
                    swapText(element.querySelector('h2'), imagePreview.querySelector('h2'));
                }
            })
        }

        function onFilterSearch(selector) {
            var input = document.querySelector(selector);
            var items = document.querySelectorAll('#container > ul > li');

            input.addEventListener('input', function (ev) {
                var regExp = new RegExp(ev.target.value, 'i');

                for (var i = 0; i < items.length; i += 1) {
                    var title = items[i].querySelector('h2').innerText;
                    if(title.match(regExp)){
                        items[i].style.display = '';
                    }else {
                        items[i].style.display = 'none';
                    }
                }
            })
        }

        addFilterElements();
        addImgElements();

        onImgHover('#container > ul');
        onImgClick('#container > ul')
        onFilterSearch('#container > label > input')
    }
}

module.exports = solve;