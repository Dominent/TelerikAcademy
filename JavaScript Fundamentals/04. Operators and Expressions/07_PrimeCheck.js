function solve (args) {

    var input = parseInt(args);
    var isPrime = true;

    if(input != 1 && input != 0 && input > 0){
         for (var index = 2; index <= Math.sqrt(input); index+=1) {
            if(input % index == 0){
                isPrime = false;
            }
        }
    }else{
        isPrime = false
    }

    console.log(isPrime);
   
}

solve(-3);
solve(23);
solve(23);