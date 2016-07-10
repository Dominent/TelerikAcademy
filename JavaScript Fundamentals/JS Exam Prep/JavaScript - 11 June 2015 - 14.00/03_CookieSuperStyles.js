function solve(args) {
    args = args.join(' ');

    // console.log(args);

    var pattern = /(\s+)/g;
    args = args.replace(pattern, '');

    // console.log('\n');
    // console.log(args);

    pattern = /;(?=})/g;

    args = args.replace(pattern, '');

    // console.log('\n');
    console.log(args);
}

solve([
    ' #the-big-b{',
    'color: yellow;',
    'size: big;',
    '}',
    '.muppet{',
    'powers: all;',
    'skin: fluffy;',
    '}',
    '.water-spirit{powers: water;',
    'alignment : not-good;',
    '}',
    'all{',
    'meant-for: nerdy-children;',
    '}',
    '.muppet {',
    'powers: everything;',
    '}',
    'all .muppet {',
    'alignment : good ;',
    '}',
    '.muppet+ .water-spirit{',
    'power: everything-a-muppet-can-do-and-water;',
    '}'
]);

