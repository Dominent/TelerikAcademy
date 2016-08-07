function solve(params) {
    var n = parseInt(params[0]);
    params = params.slice(1).map(Number);

    var current = params[0];
    var count = 0;
    var isInSeq = false;

    for (var i = 0; i < n - 1; i += 1) {
        var next = params[i + 1];

        if (current <= next) {
            isInSeq = true;
        } else {
            count += 1;
            isInSeq = false;
        }

        current = next;
    }

    count += 1;
    console.log(count);

}

// solve(
//     [
//         '7',
//         '1',
//         '2',
//         '-3',
//         '4',
//         '4',
//         '0',
//         '1'
//     ]
// )

solve(
    [
        '6',
        '1',
        '3',
        '-5',
        '8',
        '7',
        '-6'

    ]
)

// solve(
//     [
//         '9',
//         '1',
//         '8',
//         '8',
//         '7',
//         '6',
//         '5',
//         '7',
//         '7',
//         '6',
//     ]
// )


