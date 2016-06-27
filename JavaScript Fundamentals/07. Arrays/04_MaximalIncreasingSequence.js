function solve(args) {
    'use strict'
    args = args[0].split('\n');
    var n = +args[0];
    var input = args.slice(1);

    var count = 1;
    var bestCount = 0;

    var current = +input[0];
    for (var j = 0; j < n - 1; j += 1) {
        var next = +input[j + 1];
        if (current < next) {
            count++;
        } else {
            if (count > bestCount) {
                bestCount = count;
            }
            count = 1;
        }
        current = +input[j + 1];
    }

    if (count > bestCount) {
        bestCount = count;
    }

    console.log(bestCount);
}

solve(['8\n7\n3\n2\n3\n4\n2\n2\n4']);