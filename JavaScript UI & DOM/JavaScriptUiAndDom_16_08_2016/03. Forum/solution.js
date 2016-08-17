function solve() {
	return function () {
		var template = [
			'<h1>{{this.title}}</h1>' +
			'<ul>' +
				'{{#each this.posts}}' +
				'<li>' +
					'<div class="post" >' +
						'<p class="author">' +
							'<a class="{{#if author}}user{{else}}anonymous{{/if}}"{{#if author}}href="/user/{{this.author}}"{{/if}}>{{#if author}}{{this.author}}{{else}}Anonymous{{/if}}</a> ' +
						'</p>' +
						'<pre class="content">{{{this.text}}}</pre>' +
					'</div >' +
					'<ul>' +
						'{{#each this.comments}}' +
						'{{#unless deleted}}'+
						'<li>'+
							'<div class="comment">'+
								'<p class="author">'+
									'<a class="{{#if author}}user{{else}}anonymous{{/if}}" {{#if author}}href="/user/{{this.author}}"{{/if}}>{{#if author}}{{this.author}}{{else}}Anonymous{{/if}}</a> '+
								'</p>'+
								'<pre class="content">{{this.text}}' +
								'</pre>'+
							'</div>' +
						'</li>' +
						'{{/unless}}' +
						'{{/each}}' +
					'</ul>' +
				'</li>' +
				'{{/each}}'+
			'</ul>'
		].join('\n');

		return template;
	}
}

// submit the above

if (typeof module !== 'undefined') {
	module.exports = solve;
}
