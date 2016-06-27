function solve(args) {
    var fromZeroToNine = ['Zero', 'One', 'Two', 'Three', 'Four', 'Five', 'Six', 'Seven', 'Eight', 'Nine'];

    for(var i = 0; i < args.toString().length; i += 1){

        var bla1 = args.toString().length;
        var bla2 = args[(args.toString().length - i + 1)];
        var bla = fromZeroToNine[args[(args.toString().length - i)]];
        
        console.log(bla);
        console.log(bla2);
        console.log(bla1);
    }
}

console.log(solve(9));