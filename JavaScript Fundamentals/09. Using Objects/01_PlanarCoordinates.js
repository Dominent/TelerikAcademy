function solve(args) {
    args = args;

    function CreateLine(xA, yA, xB, yB) {
        return {
            pointA: { x: xA, y: yA },
            pointB: { x: xB, y: yB }
        }
    }

    function GetLength(xA, yA, xB, yB) {
        var a = Math.abs(xA - xB);
        var b = Math.abs(yA - yB);


        return Math.sqrt((a * a) + (b * b));
    }

    function CanBuild(a, b, c) {
        if (
            (a + b) > c &&
            (a + c) > b &&
            (b + c) > a
        ) {
            return 'Triangle can be built';
        } else {
            return 'Triangle can not be built';
        }
    }

    var lines = [
        CreateLine(+args[0], +args[1], +args[2], +args[3]),
        CreateLine(+args[4], +args[5], +args[6], +args[7]),
        CreateLine(+args[8], +args[9], +args[10], +args[11])
    ];

    var linesLength = new Array(3);
    for (var i = 0; i < 3; i += 1) {
        linesLength[i] = GetLength(lines[i].pointA.x, lines[i].pointA.y, lines[i].pointB.x, lines[i].pointB.y);
    }


    for (var i = 0; i < 3; i += 1) {
        console.log(linesLength[i].toFixed(2));
    }

    console.log(
        CanBuild
            (
            linesLength[0],
            linesLength[1],
            linesLength[2]
            )
    );
}


solve([
    '5', '6', '7', '8',
    '1', '2', '3', '4',
    '9', '10', '11', '12'
]);