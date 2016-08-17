function solve() {
    return function (element, contents) {

        //Any of the function params is missing
        if ((!element) || (!contents)) {
            throw new Error();
        }

        //The provided first parameter is neither string or existing DOM element
        if (typeof element != 'string') {
            if (!(element instanceof HTMLElement)) {
                throw new Error();
            } else if (element instanceof HTMLElement) {
                if (!(document.contains(element))) {
                    throw new Error();
                }
            }
        }

        if (!(element instanceof HTMLElement)) {
            //The provided id does not select anything (there is no element that has such an id)
            if (!(document.getElementById(element))) {
                throw new Error();
            }
            element = document.getElementById(element);
        }

        //Any of the contents is neither string nor number 
        //  In that case, the content of the element must not be changed
        var docFragment = document.createDocumentFragment();
        for (var i = 0; i < contents.length; i += 1) {
            if (typeof contents[i] !== 'string' && typeof contents[i] !== 'number') {
                throw new Error();
            }
            var div = document.createElement('div');
            div.innerHTML = contents[i];
            docFragment.appendChild(div);
        }

        element.innerHTML = '';
        element.appendChild(docFragment);
    }
}

var test = solve();
test('test', [
    '<ul>',
    '<li>This is awesome</li>',
    '</ul>'
]);

