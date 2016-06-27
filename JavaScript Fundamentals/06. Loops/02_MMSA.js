function solve(args) {
    var max = Number.MIN_VALUE;
    var min = Number.MAX_VALUE;
    var sum = 0;

    for (var i = 0; i < args.length; i++) {
        max = Math.max(max, +args[i]);
        min = Math.min(min, +args[i]);
        sum += +args[i];
    }

    console.log('min=' + min.toFixed(2).toString());
    console.log('max=' + max.toFixed(2).toString());
    console.log('sum=' + sum.toFixed(2).toString());
    console.log('avg=' + (sum / args.length).toFixed(2).toString());
}


solve(['2', '5', '1']);
solve(['2', '-1', '4']);