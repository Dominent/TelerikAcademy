function solve(args) {
    function Person(setFirstname, setLastname, setAge) {
        return {
            firstname: setFirstname,
            lastname: setLastname,
            age: setAge
        }
    }

    var persons = [];
    for (var j = 0; j < args.length; j += 3) {
        persons.push(Person(args[j], args[j + 1], +args[j + 2]))
    }

    for (var i = 1; i < persons.length; i += 1) {
        if (youngestPerson.age > persons[i].age) {
            youngestPerson = persons[i];
        }
    }

    console.log(youngestPerson.firstname + ' ' + youngestPerson.lastname);
}

solve(
    [
        'Gosho', 'Petrov', '32',
        'Bay', 'Ivan', '81',
        'John', 'Doe', '42'
    ]
);