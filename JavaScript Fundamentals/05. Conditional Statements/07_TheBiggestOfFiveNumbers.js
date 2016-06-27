function solve(args){
    console.log(Math.max.apply(null, args.map(Number)));
}

solve(['5', '2', '2', '4', '1']);