let distacia = parseInt(gets());
let totalCombustivel = parseFloat(gets());
let consumo = parseFloat(distacia / totalCombustivel).toFixed(3);

console.log(consumo + " km/l");