function solve(args) {
    'use strict'
    args = args[0].split('\n');
    var n = +args[0];
    var input = args.slice(1);

    var count = 1;
    var bestCount = 0;

    var current = +input[0];
    for (var i = 0; i < n - 1; i += 1) {
        var next = + input[i + 1];
        if (current === next) {
            ++count;
        }
        else {
            if (count > bestCount) {
                bestCount = count;
            }
            count = 1;
        }
        current = + input[i + 1];
    }

    if (count > bestCount) {
        bestCount = count;
    }
    
    console.log(bestCount);
}

solve(['10\n2\n1\n1\n2\n3\n3\n2\n2\n2\n1']);

