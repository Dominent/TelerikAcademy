function solve(args) {
    var input = args;
    for (var i = 0; i < input.length; i += 1) {
        input += args[i].replace(/<.*?>/ig, '').trim();
    }

    return output;
}

solve(
    [
        '<html>',
        '  <head>',
        '    <title>Sample site</title>',
        '  </head>',
        '  <body>',
        '    <div>text',
        '      <div>more text</div>',
        '      and more...',
        '    </div>',
        '    in body',
        '  </body>',
        '</html>'
    ]
)
