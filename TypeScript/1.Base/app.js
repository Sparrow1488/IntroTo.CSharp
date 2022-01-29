var User = /** @class */ (function () {
    function User(name) {
        this.name = name;
    }
    return User;
}());
var Config = /** @class */ (function () {
    function Config(connection) {
        this.connectionString = connection;
    }
    return Config;
}());
console.log("Hello, TS!");
var valek = new User("Валек");
document.querySelector(".hello").innerHTML = valek.name + ", ну как там с деньгами?";
console.log("Типа строгая типизация (ура блин!!! )");
var sVariable = "Какая то переменная";
var isValid = false;
var some = "Это типа строка";
console.log(some);
some = 10;
console.log(some);
if (typeof some === "number") {
    var result = div(some, 5);
    console.log(result);
}
console.log("Добавим друзей нашему пользователю");
valek = addRndFriends(valek);
valek.friends.forEach(function (friend) {
    console.log(friend);
});
console.log(valek.friends);
configure(function (config) {
    console.log("Настроим конфигурацию", config);
    if (!config) {
        config = new Config("EmptyConnectionString");
    }
    config.value = "SomeValue";
    config.id = 14;
    return config;
});
function sum(a, b) {
    return a + b;
}
function div(a, b) {
    return a / b;
}
function addRndFriends(user) {
    user.friends = [new User("Юрый"),
        new User("Гохлиус"),
        new User("Игорямбус")];
    return user;
}
function configure(meth) {
    var config = new Config("connectionStringValue");
    meth(config).isConfigured = true;
    console.log(config);
}
