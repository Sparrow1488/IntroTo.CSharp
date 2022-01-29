class User {
    constructor(name : string) {
        this.name = name; 
    }
    
    name : string;
    age : number;
    friends : User[];
}

console.log("Hello, TS!");
let valek : User = new User("Валек");
document.querySelector(".hello").innerHTML = valek.name + ", ну как там с деньгами?";

console.log("Типа строгая типизация (ура блин!!! )");
let sVariable : string = "Какая то переменная";
let isValid : boolean = false;
let some : any = "Это типа строка";
console.log(some);
some = 10;
console.log(some);
if(typeof some === "number"){
    let result : number = div(some, 5);
    console.log(result);
}

console.log("Добавим друзей нашему пользователю");
valek = addRndFriends(valek);
valek.friends.forEach(friend => {
    console.log(friend);
});
console.log(valek.friends);

function sum(a : number, b : number) : number {
    return a + b;
}

function div(a : number, b : number) : number {
    return a / b;
}

function addRndFriends(user : User) : User {
    user.friends = [new User("Юрый"),
                    new User("Гохлиус"),
                    new User("Игорямбус")];
    return user;
}