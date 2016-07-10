function solve(args) {
    args[0].replace(/(.*?):\/\/(.*?)(\/.*)/g, function ($1, $2, $3, $4) {
        console.log('protocol: ' + $2);
        console.log('server: ' + $3);
        console.log('resource: ' + $4);
    })
}

solve(
    [
        'http://telerikacademy.com/'
    ]
);
