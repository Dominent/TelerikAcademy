function solve(args) {
    var pattern = args[0];

    var text = args[1];

    var regExp = new RegExp(pattern, 'gi');

    var count = text.match(regExp).length;

    console.log(count);

}

solve(
    [
        'in',
        'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.'
    ]
);