function solve(args){
  
  var array = ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine'];

  var isNumber =  /^\d+$/.test(args);

  var input = parseInt(args);

  if(isNumber){
    if(input <=9 && input >=0 ){
      console.log(array[input]);
    }else{
      console.log('not a digit');
    }
  }else{
    console.log('not a digit');
  }
}