function solve(args) {
    args = args[0].split('\n');
    var n = +args[0];
    args = args.slice(1);

    for (var k = 0; k < n; k += 1) {
        args[k] = +args[k];
    }

    var count = 1;
    var bestCount = 0;
    var bestNum = 0;

    args.sort();

    var current = args[0];

    for (var i = 0; i < n; i += 1) {
        if (current === args[i + 1]) {
            count++;
        } else {
            if (count >= bestCount) {
                bestCount = count;
                bestNum = current;
            }
            current = args[i + 1];
            count = 1;
        }
    }

    if (count > bestCount) {
        bestCount = count;
        bestNum = current;
    }

      console.log(bestNum + ' (' + bestCount + ' times)');
}

solve(['13\n4\n1\n1\n4\n2\n3\n4\n4\n1\n2\n4\n9\n3']);