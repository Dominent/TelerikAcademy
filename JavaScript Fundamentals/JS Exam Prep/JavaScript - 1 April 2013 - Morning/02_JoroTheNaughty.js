function solve(args) {
    var input = args[0].split(' ').map(Number);
    var n = input[0];
    var m = input[1];
    var j = input[2];
    input = args[1].split(' ').map(Number);
    var r = input[0];
    var c = input[1];
    var jumps = args.slice(2);

    var rows = n;
    var cols = m;

    var matrix = new Array(rows);
    for (var i = 0; i < rows; i += 1) {
        matrix[i] = new Array(cols);
    }

    for (var i = 0; i < rows; i += 1) {
        for (var j = 0,
            k = (n - m === 0 ? ((i * rows)) + 1 : ((i * rows) + i) + 1);
            j < cols;
            j += 1, k += 1) {
            matrix[i][j] = k;
        }
    }

    var sum = 0;
    var count = 0;

    var x = r;
    var y = c;
    var hasEscaped = false;
    var hasBeenCaptured = false;
    while (!hasEscaped && !hasBeenCaptured) {
        for (var i = 0; i < jumps.length; i += 1) {
            var jump = jumps[i].split(' ').map(Number);

            if ((x >= rows || x < 0) || (y >= cols || y < 0)) {
                hasEscaped = true;
                break;
            }
            else if (matrix[x][y] === 'V') {
                hasBeenCaptured = true;
                break;
            } else {
                sum += matrix[x][y];
                count += 1;
                matrix[x][y] = 'V';

                x += jump[0];
                y += jump[1];
            }
        }
    }

    if (hasBeenCaptured) {
        return('caught ' + count);
    } else {
       return('escaped ' + sum);
    }
}

var test = [
    '6 7 3',
    '0 0',
    '2 2',
    '-2 2',
    '3 -1',
]

solve(test);
