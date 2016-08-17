function solve() {
    return function (selector1, selector2) {
        var template1 =
            '<ul class="books-list">' +
            '{{#books}}' +
                '<li class="book-item">' +
                    '<a href="#" data-id="{{this.id}}">' +
                        '<strong class="book-title">{{this.title}}</strong>' +
                        '<span class="author">by {{this.author}}</span>' +
                    '</a>' +
                '</li>' +
            '{{/books}}' +
            '</ul>';

        var element1 = document.getElementById(selector1);
        element1.innerHTML = template1;

        var template2 = 
        '<div class="book-details">' +
			'<h2 class="book-title">' +
				'{{this.title}}' +
			'</h2>' +
			'<p><span class="isbn">{{this.isbn}}</span></p>' +
			'<p>Published on <span class="publish-date">{{this.publicationDate}}</span> by <strong class="author">{{this.author}}</strong></p>' +
			'<p class="description">{{this.description}}</p>' +
		'</div>';

        var element2 = document.getElementById(selector2);
        element2.innerHTML = template2;
    }
}

