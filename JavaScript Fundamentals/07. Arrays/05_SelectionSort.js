function solve(args) {
    'use strict'
    args = args[0].split('\n');
    var n = +args[0];
    args = args.slice(1);

    for(var k = 0; k < n; k+=1){
        args[k] = +args[k];
    }

    for (var i = 0; i < n; i += 1) {
        var current = args[i];
        for (var j = i; j < n; j += 1) {
            if (current > args[j]) {

                args[i] = args[i] + args[j];
                args[j] = args[i] - args[j];
                args[i] = args[i] - args[j];

                current=args[i];

            }else{
                continue;
            }

        }
    }

    return args.join('\n');

}

solve(['6\n3\n4\n1\n5\n2\n6']);