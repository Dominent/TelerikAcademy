function solve(args) {
    var input = +args;

    for (var i = 0, k = 1; i < input; i++ , k++) {
        var matrix = new Array(input);
        for (var j = k, v = 0; j < input + k; j++ , v++) {
            matrix[v] = j;
        }
        console.log(matrix.join(' '));
    }
}

solve(['2']);
solve(['3']);
solve(['4']);