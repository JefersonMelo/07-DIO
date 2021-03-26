let valor = parseInt(gets());
const cedulas = [100, 50, 20, 10, 5, 2, 1];

console.log(valor);

for (let nota of cedulas) {
    let qtdCedulas = parseInt(valor / nota);
    console.log(`${qtdCedulas} nota(s) de R$ ${nota},00`); 
    valor %= nota; 
}