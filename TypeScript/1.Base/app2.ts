class Game {
    constructor(name : string){
        this.name = name;
    }

    readonly name : string;
    levels : number;
    toString() : string {
        return `[${this.name}] lvls: ${this.levels}`;
    };
}

class MyGame extends Game {
    constructor(name : string, creator : string){
        super(name);
        this.creator = creator;
    }

    readonly creator : string;
}


const game = new Game("SuperGame");
game.levels = 12;
console.log(game.toString());

const myGame : Game = new MyGame("MiniGame", "Sparrow1488");
const noGame : Game = new Game("NotGame");
console.log(`Creator is ${(myGame as MyGame).creator}`);
console.log(`Creator is ${(noGame as MyGame).creator}`); // undefined

type Action = (a : number, b : number) => number;
const result = operation((a, b) => {
    return a + b;
});
console.log(`Результат: ${result}`);

function operation(action : Action) : number {
    return action(100, 50);
}