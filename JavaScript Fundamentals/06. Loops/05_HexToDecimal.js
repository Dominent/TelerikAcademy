function solve(args) {
    var hex = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'];
    var power = 1;
    var output = 0;
    var base = 16;

    for (var i = args[0].length - 1; i >= 0; i--) {
        output += hex.indexOf(args[0][i]) * power;
        power *= base;
    }

    console.log(output);
}

solve(['FE']);
solve(['1AE3']);
