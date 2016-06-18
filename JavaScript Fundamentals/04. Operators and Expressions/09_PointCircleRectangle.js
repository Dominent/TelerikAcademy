function solve(args) {

    function inCircle(paramsCircle) {

        var xCircle = parseFloat(paramsCircle[0]),
            yCircle = parseFloat(paramsCircle[1]);

        var distance = Math.sqrt( ( ( xCircle - 1 ) * ( xCircle - 1 ) ) + ( ( yCircle - 1 ) * ( yCircle - 1 ) ) );
        var distanceFixed = distance.toFixed(2);
    
        return distance <= 1.5; 

    }

    function inRectangle(paramsRect) {
        var xRect = parseFloat(paramsRect[0]),
            yRect = parseFloat(paramsRect[1]);

            return ((xRect <= 5 && xRect >= - 1)&&(yRect <= 1 && yRect >= -1))
    }

    if(inCircle(args) && inRectangle(args)){
        console.log('inside circle inside rectangle');
    }else if(inCircle(args) && !inRectangle(args)){
        console.log('inside circle outside rectangle');
    }else if(!inCircle(args) && inRectangle(args)){
        console.log('outside circle inside rectangle');
    }else{
        console.log('outside circle outside rectangle');
    }
}

solve(['2.5', '2'])