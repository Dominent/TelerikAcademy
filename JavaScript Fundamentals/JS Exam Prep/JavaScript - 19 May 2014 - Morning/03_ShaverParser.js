function solve(params) {
    var s = +params[0];
    var replace = params.slice(1, s + 1);
    var m = +params[s + 1];
    params = params.slice(s + 2);

    var pattern = /@(?=\s*@)/g;
    params = params.map(function (x) {
        return x.replace(pattern, '');
    });

    for (var i = 0; i < s; i += 1) {
        var splitReplace = replace[i].split(':');
        var patternStr = '@' + splitReplace[0];
        var replaceStr = splitReplace[1];

        params = params.map(function (x) {
            return x.replace(patternStr, replaceStr);
        });
    }

    console.log(params.join('\n'));
}

solve(
    [
        '6',
        'title:Telerik Academy',
        'showSubtitle:true',
        'subTitle:Free training',
        'showMarks:false',
        'marks:3, 4, 5, 6',
        'students:Pesho, Gosho, Ivan',
        '42',
        '@section menu {',
        '<ul id="menu">',
        '<li>Home</li>',
        '<li>About us</li>',
        '</ul >',
        '}',
        '@section footer {',
        '<footer>',
        'Copyright Telerik Academy 2014',
        '</footer>',
        '}',
        '<!DOCTYPE html>',
        '<html>',
        '<head>',
        '  <title>Telerik Academy</title>',
        '</head>',
        '<body>',
        '@renderSection("menu")',
        '<h1> @title</h1>',
        '@if (showSubtitle) {',
        '<h2> @subTitle</h2>',
        '<div> @ @JustNormalTextWithDoubleKliomba;) </div>',
        '}',
        '<ul>',
        '@foreach (var student in students) {',
        '<li>',
        '@student',
        '</li>',
        '<li>Multiline @title</li>',
        '}',
        '</ul>',
        '@if (showMarks) {',
        '<div>',
        '@marks',
        '</div>',
        '}',
        '@renderSection("footer")',
        '</body >',
        '</html >'
    ]
)