function solve(params) {
    var rows = parseInt(params[0]),
        cols = parseInt(params[1]),
        tests = parseInt(params[rows + 2]);
    var move;

    //Creates a 2 Dimensional Jagged Array!
    function Create2DArray(row, col) {
        var array2D = new Array(col);
        for (var i = 0; i < col; i += 1) {
            array2D[i] = new Array(row);
        }
        return array2D;
    }

    //Move straight Logic!
    function moveStraight(xF, yF, xS, yS, input) {
        if (xF === xS) {
            for (var i = xF; i <= xS; i += 1) {
                if (input[i][yF] !== '-') {
                    return false;
                }
            }
        } else if (yF === yS) {
            for (var i = yF; i <= yS; i += 1) {
                if (input[xF][i] !== '-') {
                    return false;
                }
            }
        }
        else {
            return false;
        }

        return true;
    }

    function moveDiagonal(xF, yF, xS, yS, input) {
        if ((Math.abs(xF - yF) === Math.abs(xS - yS)) ||
            (Math.abs(xF + yF) === Math.abs(xS + yS))) {

            var topRight = false;
            var topLeft = false;
            var bottomLeft = false;
            var bottomRight = false;

            if (xF > xS) {
                if (yF > yS) {
                    bottomRight = true;
                } else if (yF < yS) {
                    topRight = true;
                }
            } else if (xF < xS) {
                if (yF > yS) {
                    bottomLeft = true;
                } else if (yF < yS) {
                    topLeft = true;
                }
            }

            if (topRight) {// Works
                while (xF != xS || yF != yS) {
                    xF -= 1;
                    yF += 1;
                    if (input[xF][yF] !== '-') {
                        return false;
                    }
                }
            } else if (bottomRight) { // Works
                while (xF != xS || yF != yS) {
                    xF -= 1;
                    yF -= 1;
                    if (input[xF][yF] !== '-') {
                        return false;
                    }
                }
            } else if (topLeft) { //Works
                while (xF != xS || yF != yS) {
                    xF += 1;
                    yF += 1;
                    if (input[xF][yF] !== '-') {
                        return false;
                    }
                }
            } else if (bottomLeft) { //Works
                while (xF != xS || yF != yS) {
                    xF += 1;
                    yF -= 1;
                    if (input[xF][yF] !== '-') {
                        return false;
                    }
                }
            }

        } else {
            return false;
        }

        return true;
    }

    var start = 2;
    var board = Create2DArray(rows, cols);

    for (var j = 0; j < rows; j += 1) {
        var input = params[start + j].split('');
        for (var i = 0; i < cols; i += 1) {
            board[i][j] = input[i];
        }
    }

    var template = 'abcdefghijklmnopqrstuvwxyz'.split('');

    for (var i = 0; i < tests; i++) {
        var canMove = true;

        //ToDoIndexes dont work well huh ? rows - 1 !
        move = params[rows + 3 + i].split(' ');

        var firstPos = move[0].split('');
        var xF = template.indexOf(firstPos[0]);
        var yF = (rows) - +firstPos[1];

        var secondPos = move[1].split('');
        var xS = template.indexOf(secondPos[0]);
        var yS = (rows) - +secondPos[1];

        var start = board[xF][yF];
        var end = board[xS][yS];

        //Figure logic
        if ( end !== '-' ) {
            canMove = false;
        } else if (start === '-') {
            canMove = false;
        } else {

            //Rook logic
            if (start === 'R') {

                canMove = moveStraight(xF, yF, xS, yS, board);


                //Bishop Logic
            } else if (start === 'B') {

                canMove = moveDiagonal(xF, yF, xS, yS, board)

                //Queen Logic
            } else if (start === 'Q') {

                // if (xF === xS || yF === yS) { //Hackfix
                    canMove = moveStraight(xF, yF, xS, yS, board);
                // } else {
                    canMove = moveDiagonal(xF, yF, xS, yS, board);
                // }

            }
        }



        console.log(canMove ? 'yes' : 'no');
    }
}

solve(
    [
        '3', '4',
        '---R', 'B--B', 'Q--Q',
        '12',
        'd1 b3', 'a1 a3', 'c3 b2', 'a1 c1', 'a1 b2', 'a1 c3', 'a2 b3', 'd2 c1', 'b1 b2', 'c3 b1', 'a2 a3', 'd1 d3'
    ]
);


// solve(
//     [
//         '3', '4',
//         '---R', 'B--B', 'Q--Q',
//         '12',
//        'a1 b2'
//     ]
// );
