function solve(args) {

    var a = +(args[0]),
        b = +(args[1]),
        c = +(args[2]);

    var discriminant = (b * b) - (4 * (a * c));

    if(discriminant > 0){
        var x2 = (-b + Math.sqrt(discriminant))/ (2 * a);
        var x1 = (-b - Math.sqrt(discriminant))/ (2 * a);

        console.log('x1=' + x1.toFixed(2) + '; ' + 'x2=' + x2.toFixed(2));
    }else if(discriminant === 0){
        var x = -b/(2 * a);

         console.log('x1=x2=' + x.toFixed(2));
    }else{
        console.log('no real roots');
    }
}

// solve(['2', '5', '-3']);
solve(['-0.5', '4', '-8']);

