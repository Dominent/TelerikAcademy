function solve(args) {
    var rows = +args[0].split(' ')[0];
    var cols = +args[0].split(' ')[1];

    var sum = 1;

    function GenerateMatrix(rows, cols) {
        var matrix = new Array(rows);
        for (var i = 0; i < rows; i += 1) {
            matrix[i] = new Array(cols);
        }
        return matrix;
    }

    var dirMatrix = GenerateMatrix(rows, cols);

    for (var i = 0; i < rows; i += 1) {
        var input = args[i + 1].split(' ');
        for (var j = 0; j < cols; j += 1) {
            dirMatrix[i][j] = input[j];
        }
    }

    var x = 0;
    var y = 0;
    while (1) {
        var dir = dirMatrix[y][x];
        if (dir == 'dr') {
            if (
                ((x + 1) < (cols))
                && ((y + 1) < (rows))
            ) {
                if (dirMatrix[y + 1][x + 1] === 'V') { // this check is not correct
                    console.log('failed at (' + (y + 1) + ', ' + (x + 1) + ')');
                    break;
                } else {
                    dirMatrix[y][x] = 'V';
                    x += 1;
                    y += 1;
                    sum += Math.pow(2, y) + x;
                }
            } else {
                console.log('successed with ' + sum);
                break;
            }
        } else if (dir == 'dl') {
            if (
                ((x - 1) < (cols))
                && ((y + 1) < (rows))
                && (x - 1 >= 0)
            ) {
                if (dirMatrix[y + 1][x - 1] === 'V') {
                    console.log('failed at (' + (y + 1) + ', ' + (x - 1) + ')');
                    break;
                } else {
                    dirMatrix[y][x] = 'V';
                    x -= 1;
                    y += 1;
                    sum += Math.pow(2, y) + x;
                }
            } else {
                console.log('successed with ' + sum);
                break;
            }
        } else if (dir == 'ur') {
            if (
                ((x + 1) < (cols))
                && ((y - 1) < (rows))
                && (y - 1 >= 0)
            ) {
                if (dirMatrix[y - 1][x + 1] === 'V') {
                    console.log('failed at (' + (y - 1) + ', ' + (x + 1) + ')');
                    break;
                } else {
                    dirMatrix[y][x] = 'V';
                    x += 1;
                    y -= 1;
                    sum += Math.pow(2, y) + x;
                }
            } else {
                console.log('successed with ' + sum);
                break;
            }
        } else if (dir == 'ul') {
            if (
                ((x - 1) < (cols))
                && ((y - 1) < (rows))
                && (y - 1 >= 0)
                && (x - 1 >= 0)
            ) {
                if (dirMatrix[y - 1][x - 1] === 'V') {
                    console.log('failed at (' + (y - 1) + ', ' + (x - 1) + ')');
                    break;
                } else {
                    dirMatrix[y][x] = 'V';
                    x -= 1;
                    y -= 1;
                    sum += Math.pow(2, y) + x;
                }

            } else {
                console.log('successed with ' + sum);
                break;
            }
        }
    }
}
// solve(
//     [
//         '3 5',
//         'dr dl dr ur ul',
//         'dr dr ul ur ur',
//         'dl dr ur dl ur'
//     ]
// )

solve([
    '3 5',
    'dr dl dl ur ul',
    'dr dr ul ul ur',
    'dl dr ur dl ur'
])