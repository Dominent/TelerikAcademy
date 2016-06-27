function solve(args) {
    args = args[0].split('\n');
    var n = +args[0];
    var x = +args[args.length - 1];
    args = args.slice(1, args.length - 1);

    var low = 0;
    var high = n;


    while (low <= high) {
        var mid = Math.floor(low + (high - low) / 2);

        if (+args[mid] < x) {
            low = mid + 1;
        }

        if (+args[mid] > x) {
            high = mid - 1;
        }

        if (+args[mid] == x) {
            return mid;
        }
    }

    return -1;
}

solve(['10\n1\n2\n4\n8\n16\n31\n32\n64\n77\n99\n32']);