function solve(args) {

    var input = parseInt(args);
    var isTrue = false;
    var count = 0;
    var thirdDigit = 0;

    while(input > 1){

        count += 1;

        var digit = parseInt((input % 10));

        input /= 10;

        if(count == 3 ){
            if(digit == 7){
                isTrue = true;
            }
            else{
                thirdDigit = digit;
            }
        }
    }

    isTrue ? console.log('true') : console.log('false ' + thirdDigit);
    
}
