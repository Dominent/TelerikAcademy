function solve(args) {
    var createObj = function (key, value) {
        return {
            key: value
        };
    }


    for (var i = 0; i < args.length; i += 1) {
        console.log(args[i]);
    }
}

var test =
    [
        '(def func 10)',
        '(def newFunc (+  func 2))',
        '(def sumFunc (+ func func newFunc 0 0 0))',
        '(* sumFunc 2)'
    ];

solve(test);