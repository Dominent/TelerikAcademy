function solve (args){

    var a = parseFloat(args[0]),
        b = parseFloat(args[1]),
        h = parseFloat(args[2]);

    var area = h * ((a + b)/2);

    console.log(area.toFixed(7));

}

solve(['5', '7', '12']);