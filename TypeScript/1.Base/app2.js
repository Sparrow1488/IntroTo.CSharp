var result = operation(function (a, b) {
    return a + b;
});
console.log(result);
function operation(action) {
    return action(100, 50);
}
