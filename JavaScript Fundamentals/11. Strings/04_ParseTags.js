function solve(args) {
    var tag = [];
    var result = [];

    var text = args;
    text = text.replace(/<\s*upcase\s*>/gi, '<U>')
        .replace(/<\s*\/upcase\s*>/gi, '</U>')
        .replace(/<\s*lowcase\s*>/gi, '<L>')
        .replace(/<\s*\/lowcase\s*>/gi, '</L>')
        .replace(/<\s*orgcase\s*>/gi, '<O>')

        
        .replace(/<\s*\/orgcase\s*>/gi, '</O>');

    var text = text.split('');
    var inTag = false;
    var inClosingTag = false;

    for (var i = 0; i < text.length; i += 1) {
        var ch = text[i];

        if (ch === '<') {
            inTag = true;
            continue;
        }

        if (ch === '/' && inTag) {
            inClosingTag = true;
            continue;
        }

        if (inTag & !inClosingTag && text[i].match(/[a-z]/i)) { //
            tag.push(text[i])
            continue;
        }

        if (ch === '>') {
            if (inClosingTag) {
                tag.pop();
                inClosingTag = false;
            }
            inTag = false;
            continue;
        }

        if (!inTag) {
            if (!tag.length) {
                result.push(ch);
            } else {
                switch (tag[0]) {
                    case 'L':
                        result.push(ch.toLowerCase());
                        break;
                    case 'U':
                        result.push(ch.toUpperCase());
                        break;
                    case 'O':
                        result.push(ch);
                        break;
                }
            }
        }
    }
    return result.join('');
}

var tests = [
    'We are <orgcase>liViNg</orgcase> in a <upcase>yellow<lowcase>submarine</lowcase></upcase>. We <orgcase>doN\'t</orgcase> have <lowcase>anything <upcase>this is Sparta</upcase> </lowcase> else.',
    '<upcase>text<lowcase>Text</lowcase></upcase>'
]

for (var i = 0; i < tests.length; i += 1) {
    solve(tests[i]);
}