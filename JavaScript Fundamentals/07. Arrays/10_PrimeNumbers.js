function solve(args) {
    var number = +args[0];

    for (var i = number; i >= 2; i -= 1) {
        var isPrime = true;
        for (var k = 2; k < Math.sqrt(number); k += 1) {
            if (i % k == 0) {
                isPrime = false;
                break;
            }
        }
        if (isPrime == true) {
            return i;
        }
    }

    return -1;
}

solve(['13']);