function solve(args) {
    String.prototype.jsonToString = function (json) {
        var obj = JSON.parse(json);

        var text = this.replace(/#{(.*?)}/g, function ($1, $2) {
            return obj[$2];
        });

        return text;
    }

    return (args[1].jsonToString(args[0]));
}

solve(
    [
        '{ "name": "John" }',
        "Hello, there! Are you #{name}?"
    ]
);

solve(
    [
        '{ "name": "John", "age": 13 }',
        "My name is #{name} and I am #{age}-years-old"
    ]
);

