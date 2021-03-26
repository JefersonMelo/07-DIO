let cont = 0;
let valor = 0;

for (let index = 0; index < 6; index++) {

    valor = parseInt(gets());

    if (valor > 0) {
        cont++;
    }

}
console.log(cont + " valores positivos");