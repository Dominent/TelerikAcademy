function solve(args) {
    var input = args.toString().split("");
    var numToWord = ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine'];

    console.log(numToWord[+input[input.length - 1]]);
}


solve(42);