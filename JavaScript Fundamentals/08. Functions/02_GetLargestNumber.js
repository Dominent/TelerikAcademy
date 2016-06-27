function solve(args) {
    var input = args[0].split(' ');

    function GetMax(a, b) {
        if (a > b) {
            return a;
        } else if (a < b) {
            return b;
        } else {
            return a;
        }
    }

    var output = GetMax(+input[0], GetMax(+input[1], +input[2]));
    console.log(output);
}

solve(['8 3 6'])





