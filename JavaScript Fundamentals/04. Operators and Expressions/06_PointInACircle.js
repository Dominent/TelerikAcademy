function solve(args) {
    
    var x = parseFloat(args[0]),
        y = parseFloat(args[1]);

    var distance = Math.sqrt( ( ( x - 0 ) * ( x - 0 ) ) + ( ( y - 0 ) * ( y - 0 ) ) );
    var distanceFixed = distance.toFixed(2);
    
    console.log(distance <= 2? 'yes ' + distanceFixed: 'no ' + distanceFixed);

}

solve(['-2', '0']);
solve(['-1', '2']);