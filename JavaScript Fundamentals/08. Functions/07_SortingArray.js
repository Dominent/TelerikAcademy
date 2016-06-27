function solve(args) {
    // args = args[0].split('\n');
    var n = +args[0];
    args = args[1].split(' ');

    function sort(array) {
        for (var k = 0; k < array.length; k += 1) {
            array[k] = +array[k];
        }

        for (var i = 0; i < n; i += 1) {
            var current = array[i];
            for (var j = i; j < n; j += 1) {
                if (current > array[j]) {

                    array[i] = array[i] + array[j];
                    array[j] = array[i] - array[j];
                    array[i] = array[i] - array[j];

                    current = array[i];

                } else {
                    continue;
                }
            }
        }

        return array.join(' ');
    }

    var output = sort(args);
    console.log(output);
}

// solve(['6\n3 4 1 5 2 6']);
solve(['6', '3 4 1 5 2 6'])

