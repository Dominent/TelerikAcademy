function solve(args) {
    args = args[0].split('\n');
    var n = +args[0];
    var x = +args[args.length - 1];
    args = args[1].split(' ');

    var count = 0;
    for (var i = 0; i < n; i += 1) {
        if (x === +args[i]) {
            count += 1;
        }
    }

    console.log(count);
}


solve(['8\n28 6 21 6 -7856 73 73 -56\n73']);

