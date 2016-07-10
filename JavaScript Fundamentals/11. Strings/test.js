function solve(args) {
    var pattern = /<\/*orgcase>/g;
    args = args[0].replace(pattern, '');

    var text = args;

    var start = Math.min(
        args.indexOf('<upcase>'),
        args.indexOf('<lowcase>')
    );

    while (start !== -1) {
        pattern = new RegExp('<.*?>');

        var startTag = text.match(pattern)[0];
        var endTag = '</' + (startTag.slice(1, startTag.length - 1)) + '>';

        start += startTag.length;
        var end = text.indexOf(endTag);

        text = text.slice(start, end);

        start = Math.min(
            text.indexOf('<upcase>') !== -1 ?
                text.indexOf('<upcase>') : text.indexOf('<lowcase>'),
            text.indexOf('<lowcase>') !== -1 ?
                text.indexOf('<lowcase>') : text.indexOf('<upcase>')
        );

        if (start === -1) {
            pattern = new RegExp('(' + startTag + ')(' + text + ')(' + endTag + ')', 'i');
            if (startTag === '<lowcase>') {
                args = args.replace(pattern, text.toLowerCase());
            }
            if (startTag === '<upcase>') {
                args = args.replace(pattern, text.toUpperCase());
            }

            text = args;

            start = Math.min(
                text.indexOf('<upcase>') !== -1 ?
                    text.indexOf('<upcase>') : text.indexOf('<lowcase>'),
                text.indexOf('<lowcase>') !== -1 ?
                    text.indexOf('<lowcase>') : text.indexOf('<upcase>')
            );
        }
    }


    return args;
}