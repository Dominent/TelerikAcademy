function solve(args) {
    var input = args[0].split(' ').map(Number);
    var r = input[0];
    var c = input[1];
    var n = +args[2];

    input = args[1].split(';');

    var rows = r;
    var cols = c;

    var matrix = new Array(rows);
    for (var i = 0; i < rows; i += 1) {
        matrix[i] = new Array(cols);
    }

    for (var a = 0; a < rows; a += 1) {
        for (var o = 0; o < cols; o += 1) {
            matrix[a][o] = 'e';
        }
    }

    for (var j = 0; j < input.length; j += 1) {
        var temp = input[j].split(' ').map(Number);
        var x = temp[0];
        var y = temp[1];

        matrix[x][y] = 'D';
    }

    matrix[0][0] = '0';
    matrix[0][1] = '1';
    matrix[0][2] = '2';
    matrix[0][3] = '3';

    matrix[rows - 1][cols - 1] = '4';
    matrix[rows - 1][cols - 2] = '5';
    matrix[rows - 1][cols - 3] = '6';
    matrix[rows - 1][cols - 4] = '7';


    //From here on Logic

    input = args.slice(3);
    var tanks = [];
    for (var k = 0; k < n; k += 1) {
        var tmp = input[k];

        var match = tmp.substring(0, 2).trim();
        tmp = tmp.split(' ');
        var tank = tmp[1];

        var dir = tmp[tmp.length - 1];

        var X = -1;
        var Y = -1;
        for (var q = 0; q < rows; q += 1) {
            Y = matrix[q].indexOf(tank);
            if (Y !== -1) {
                X = q;
                break;
            }
        }

        if (Y === -1 || X === -1)
            continue;

        var lastCord;
        if (match === 'mv') {

            console.log(tmp);
            console.log('\n');

            var moves = +tmp[2];

            matrix[X][Y] = 'e';

            switch (dir) {
                case 'u':
                    lastCord = X;
                    for (var m = X - 1, counter = 1; m >= 0 ,counter <= moves; m -= 1, counter+=1) {
                        if (matrix[m][Y] !== 'D' &&
                            (isNaN(matrix[m][Y]))
                        ) {
                            lastCord = m;
                        } else {
                            break;
                        }
                    }
                    matrix[lastCord][Y] = tank;
                    break;
                case 'd':
                    lastCord = X;
                    for (var m = X + 1, counter = 1; m < rows, counter <= moves; m += 1, counter+=1) {
                        if (matrix[m][Y] !== 'D' &&
                            (isNaN(matrix[m][Y]))
                        ) {
                            lastCord = m;
                        } else {
                            break;
                        }
                    }
                    matrix[lastCord][Y] = tank;
                    break;
                case 'l':
                    lastCord = Y;
                    for (var m = Y - 1, counter = 1; m >= 0, counter <= moves; m -= 1, counter+=1) {
                        if (matrix[X][m] !== 'D' &&
                            (isNaN(matrix[X][m]))
                        ) {
                            lastCord = m;
                        } else {
                            break;
                        }
                    }
                    matrix[X][lastCord] = tank;
                    break;
                case 'r':
                    lastCord = Y;
                    for (var m = Y + 1, counter = 1; m < cols, counter <= moves; m += 1, counter+=1) {
                        if (matrix[X][m] !== 'D' &&
                            (isNaN(matrix[X][m]))
                        ) {
                            lastCord = m;
                        } else {
                            break;
                        }
                    }
                    matrix[X][lastCord] = tank;
                    break;
            }
        } else if (match === 'x') {

            console.log(tmp);
            console.log('\n');
            switch (dir) {
                case 'u':
                    for (var m = X - 1; m >= 0; m -= 1) {
                        if (matrix[m][Y] !== 'D' &&
                            (isNaN(matrix[m][Y]))
                        ) {
                        } else {
                            if (!isNaN(matrix[m][Y])) {
                                console.log('Tank ' + matrix[m][Y] + ' is gg');
                                tanks.push(matrix[m][Y]);
                            }
                            matrix[m][Y] = 'e';
                            break;
                        }
                    }
                    break;
                case 'd':
                    for (var m = X + 1; m < rows; m += 1) {
                        if (matrix[m][Y] !== 'D' &&
                            (isNaN(matrix[m][Y]))
                        ) {
                        } else {
                            if (!isNaN(matrix[m][Y])) {
                                console.log('Tank ' + matrix[m][Y] + ' is gg');
                                tanks.push(matrix[m][Y]);
                            }
                            matrix[m][Y] = 'e';
                            break;
                        }

                    }

                    break;
                case 'l':
                    for (var m = Y - 1; m >= 0; m -= 1) {
                        if (matrix[X][m] !== 'D' &&
                            (isNaN(matrix[X][m]))
                        ) {
                        } else {
                            if (!isNaN(matrix[X][m])) {
                                console.log('Tank ' + matrix[X][m] + ' is gg');
                                tanks.push(matrix[X][m]);
                            }
                            matrix[X][m] = 'e';
                            break;
                        }
                    }
                    break;
                case 'r':
                    for (var m = Y + 1; m < cols; m += 1) {

                        if (matrix[X][m] !== 'D' &&
                            (isNaN(matrix[X][m]))
                        ) {
                        } else {
                            if (!isNaN(matrix[X][m])) {
                                console.log('Tank ' + matrix[X][m] + ' is gg');
                                tanks.push(matrix[X][m]);
                            }
                            matrix[X][m] = 'e';
                            break;
                        }

                    }
                    break;
            }
        }



        console.log(matrix);
        console.log('\n');
    }
    var cuki = 0;
    var koce = 0;
    for (var i = 0; i < tanks.length; i += 1) {
        if (+tanks[i] >= 0 && +tanks[i] < 4) {
            cuki += 1;
        } else {
            koce += 1;
        }
    }

    console.log(cuki > koce ? 'Koceto is gg' : 'Cuki is gg');
}

var test =
    [
        '5 5',
        '2 0;2 1;2 2;2 3;2 4',
        '13',
        'mv 7 2 l',
        'x 7 u',
        'x 0 d',
        'x 6 u',
        'x 5 u',
        'x 2 d',
        'x 3 d',
        'mv 4 1 u',
        'mv 4 4 l',
        'mv 1 1 l',
        'x 4 u',
        'mv 4 2 r',
        'x 2 d'
    ];

var test2 =
    [
        '10 10',
        '1 0;1 1;1 2;1 3;1 4;4 1;4 2;4 3;4 4',
        '8',
        'mv 4 9 u',
        'x 4 l',
        'x 4 l',
        'x 4 l',
        'x 0 r',
        'mv 0 9 r',
        'mv 5 1 r',
        'x 5 u'
    ];

solve(test2);