function  solve( args ){

    var a = +args[0],
        b = +args[1];
  
    if(a > b){
        a = a + b;
        b = a - b;
        a = a - b;
    }

  console.log(a + ' ' + b);
}