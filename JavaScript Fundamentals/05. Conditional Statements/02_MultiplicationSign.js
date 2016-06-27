function solve(args){
    
    var negCount = 0;
    var hasZero = false;

    for (var i = 0; i < args.length; i++) {

        if(+args[i] === 0){
             hasZero = true;
        }else if(+args[i] < 0){
             negCount++;
        }
    }

    console.log( hasZero ? '0' : ( negCount % 2 === 0 ? '+ ' : '-' ));
}