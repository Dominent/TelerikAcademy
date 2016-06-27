function solve(args) {
    'use strict'
    var word = args[0].split('\n');

    var str1 = word[0],
        str2 = word[1];

    if (str1 > str2) {
        console.log('>');
    } else if (str1 < str2) {
        console.log('<');
    } else {
        console.log('=');
    }
}

solve(['hello', 'halo']);
solve(['food', 'food']);