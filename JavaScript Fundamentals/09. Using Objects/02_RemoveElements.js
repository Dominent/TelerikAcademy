function solve(args) {

    Array.prototype.remove = function () {
        var array = new Array(this.length);
        var input = this[0];

        for (var i = 0; i < this.length; i += 1) {
            if (this[i] != input) {
                array.push(this[i]);
            }
        }
        return array;
    }

    console.log(args.remove().join('\n'));
}

    // Array.prototype.remove = function () {
    //     var input = this[0];
    //     for (var i = 0; i < this.length; i += 1) {
    //         if (this[i] == input) {
    //             this.splice(i, 1);
    //             i -= 1;
    //             if (this[i + 1] == input) {
    //                 for (var j = i + 1; j < this.length; j += 1) {
    //                     if (this[j] == input) {
    //                         continue;
    //                     } else {
    //                         i = j;
    //                         break;
    //                     }
    //                 }
    //             }
    //         }
    //     }
    //     return this;
    // }

solve(
    [
        '_h/_',
        '^54F#',
        'V',
        '^54F#',
        'Z285',
        'kv?tc`',
        '^54F#',
        '_h/_',
        'Z285',
        '_h/_',
        'kv?tc`',
        'Z285',
        '^54F#',
        'Z285',
        'Z285',
        '_h/_',
        '^54F#',
        'kv?tc`',
        'kv?tc`',
        'Z285'
    ]
)
