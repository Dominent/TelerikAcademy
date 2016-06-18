function solve(args) {

    var width = parseFloat(args[0])
        height = parseFloat(args[1]);

    var area = width * height,
        perimeter = 2 * (width + height);

        console.log(area.toFixed(2) +  ' ' +  perimeter.toFixed(2));
        
}


