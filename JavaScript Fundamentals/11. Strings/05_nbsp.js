function solve(args) {
    console.log(args[0].replace(/ /g, '&nbsp;'));
}

solve(
    [
        'This text  contains 4 spaces!!'
    ]
)