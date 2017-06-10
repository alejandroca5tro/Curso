function setName(obj) {
    obj.name = 'Nicholas';
}

var person = new Object();
setName(person);

console.log(person['name']);