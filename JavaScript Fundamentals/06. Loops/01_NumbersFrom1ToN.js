function solve(args) {
    var input = +args;
    var output = new Array(input);

    for (var i = 0; i < input; i += 1) {
        output[i] = i + 1;
    }

    console.log(output.join(' '));
}

solve(['1']);
solve(['5']);

