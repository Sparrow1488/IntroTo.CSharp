var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Game = /** @class */ (function () {
    function Game(name) {
        this.name = name;
    }
    Game.prototype.toString = function () {
        return "[".concat(this.name, "] lvls: ").concat(this.levels);
    };
    ;
    return Game;
}());
var MyGame = /** @class */ (function (_super) {
    __extends(MyGame, _super);
    function MyGame(name, creator) {
        var _this = _super.call(this, name) || this;
        _this.creator = creator;
        return _this;
    }
    return MyGame;
}(Game));
var game = new Game("SuperGame");
game.levels = 12;
console.log(game.toString());
var myGame = new MyGame("MiniGame", "Sparrow1488");
var noGame = new Game("NotGame");
console.log("Creator ".concat(myGame.creator));
console.log("Creator ".concat(noGame.creator));
var result = operation(function (a, b) {
    return a + b;
});
console.log("\u0420\u0435\u0437\u0443\u043B\u044C\u0442\u0430\u0442: ".concat(result));
function operation(action) {
    return action(100, 50);
}
