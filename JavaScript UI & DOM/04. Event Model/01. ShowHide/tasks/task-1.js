function solve() {
	return function (selector) {
		if(!selector){
			throw new Error();
		}

		if (!(selector instanceof HTMLElement)) {
			selector = document.getElementById(selector);
		}

		var buttons = selector.getElementsByClassName('button');
		var content = selector.getElementsByClassName('content');

		for (var i = 0; i < buttons.length; i += 1) {
			buttons[i].innerHTML = 'hide';
		}

		selector.addEventListener('click', function () {
			var button = event.target;
			var next = event.target.nextSibling;
			while (true) {
				if (next.className === 'content') {
					if (next.style.display === 'none') {
						next.style.display = '';
						button.innerHTML = 'show';

					} else {
						next.style.display = 'none';
						button.innerHTML = 'hide';
					}
					break;
				}
				else if (next === null) break;
				else if (next.className === 'button') break;
				else next = next.nextSibling;
			}
		});
	}
}

module.exports = solve;