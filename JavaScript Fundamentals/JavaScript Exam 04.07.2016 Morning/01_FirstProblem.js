function solve(args) {
    // console.log(args);
    var input = (args + '').split(' ').map(Number);

    var count = 0;
    var sum = 0;

    var bestSum = 0;
    var inputLength = input.length;
    for (var i = 0; i < inputLength; i += 1) {
        var num = input[i];
        if (num > input[i + 1] &&
            num > input[i - 1]) {
            count += 1;
            // console.log(input[i]);
        } else if (i === 0 &&
            num > input[i + 1]) {
            count += 1;
            // console.log(input[i]);
        } else if (i === inputLength - 1 &&
            num > input[i - 1]) {
            count += 1;
            // console.log(input[i]);
        }

        if (count % 2 !== 0) {
            sum += input[i];
        } else {
            sum += input[i];
            if (sum > bestSum) {
                bestSum = sum;
            }
            // console.log(sum);
            sum = input[i];
            count = 1;
        }
    }


    // console.log(count);
    // console.log(input);
    console.log(bestSum);
}

var test =
    [
        '5 1 7 4 8', //19
        '5 1 7 6 5 6 4 2 3 8' //24
    ];

for (var z = 0; z < test.length; z += 1) {
    solve(test[z]);
}















