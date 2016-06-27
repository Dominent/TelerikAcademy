//  buble sort
function solve(args){
var swapped;
    args = args.map(Number);
    do{
        swapped = false;
        for (var index = 0; index < args.length - 1; index++) {
            if(args[index] > args[index + 1]){
                args[index] +=args[index + 1];
                args[index + 1] = args[index] - args[index + 1];
                args[index] -= args[index + 1];
                swapped = true;
            }
        }
    }while(swapped);

    console.log( args.reverse().join(' '));
}

solve(['4', '2', '8']);