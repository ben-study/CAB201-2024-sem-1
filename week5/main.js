// type User = {
//   name: string;
//   age: number;
//   getName: () => string;
// };
var user = {
    name: 'John',
    age: 30,
    getName: function () {
        return this.name;
    }
};
console.log(user.getName()); // John
