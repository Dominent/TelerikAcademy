function solve(args) {
    var input = args[0].split('');

    var leftBCount = 0;
    var rightBCount = 0;

    var inputLength = input.length;
    for (var i = 0; i < inputLength; i += 1) {
        if (input[i] === '(') {
            leftBCount += 1;
        }
        if (input[i] === ')') {
            rightBCount += 1;
        }
    }

    console.log((leftBCount === rightBCount) ? 'Correct' : 'Incorrect');
}



solve(
    [
        '((a+b)/5-d)'
    ]
);

solve(
    [
        ')(a+b))'
    ]
);