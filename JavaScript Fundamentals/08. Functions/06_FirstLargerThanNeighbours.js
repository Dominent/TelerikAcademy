function solve(args) {
    args = args[0].split('\n');
    var n = +args[0];
    args = args[1].split(' ');


    var count = 0;
    for (var i = 1; i < n - 1; i += 1) {
        var current = +args[i];
        if ((current > +args[i + 1]) && (current > +args[i - 1])) {
            return i;
        }
    }
    return -1;

}

solve(['6\n-26 -25 -28 31 2 27']);
