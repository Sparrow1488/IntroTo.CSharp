type Action = (a : number, b : number) => number;
const result = operation((a, b) => {
    return a + b;
});
console.log(result);

function operation(action : Action) : number {
    return action(100, 50);
}