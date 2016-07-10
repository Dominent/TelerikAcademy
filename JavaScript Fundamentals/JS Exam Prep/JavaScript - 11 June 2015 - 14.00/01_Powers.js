function solve(params) {
    var nk = params[0].split(' ').map(Number),
        s = params[1].split(' ').map(Number),
        result;

    //  each 0 - with the absolute difference of its neighboring numbers
    //  all other even numbers - with the maximum of its neighboring numbers
    //  each 1 - with the sum of its neighboring numbers
    //  all other odd numbers - with the minimum of its neighboring numbers

    var n = nk[0];
    var k = nk[1];

    var transform = function (input) {
        var leftNeighbour;
        var rightNeighbour;

        var output = [];
        var inputLength = input.length;
        for (var j = 0; j < inputLength; j += 1) {
            if (j === 0) {
                leftNeighbour = input[inputLength - 1];
                rightNeighbour = input[j + 1];
            } else if (j === inputLength - 1) {
                rightNeighbour = input[0];
                leftNeighbour = input[j - 1];
            } else {
                leftNeighbour = input[j - 1];
                rightNeighbour = input[j + 1];
            }

            if (s[j] === 0) {
                output.push(Math.abs(leftNeighbour - rightNeighbour));
            } else if (s[j] === 1) {
                output.push(Math.abs(leftNeighbour + rightNeighbour));
            } else if (s[j] % 2 === 0) {
                output.push(Math.max(leftNeighbour, rightNeighbour));
            } else if (s[j] % 2 !== 0) {
                output.push(Math.min(leftNeighbour, rightNeighbour));
            }
        }
        return output;
    }

    for (var i = 0; i < k; i += 1) {
        s = transform(s);
    }

    // console.log(nk);
    // console.log(s);

    result = 0;
    for (var i = 0; i < s.length; i += 1) {
        result += s[i];
    }
    console.log(result);
}

solve(['5 1', '9 0 2 4 1']);
