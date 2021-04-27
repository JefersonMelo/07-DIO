// a função gets é implementada dentro do sistema para ler as entradas(inputs) dos dados
let totalDeCasos = parseInt(gets());

for (let i = 0; i < totalDeCasos; i++) {

    let qtdClientes = parseInt(gets());
    let senhas = gets();
    let fila = senhas.split(" ");
    let filaOrdenada = senhas.split(" ").sort((a, b) => a - b).reverse();
    let cont = 0;
    for (let j = 0; j < qtdClientes; j++) {
        if (fila[j] == filaOrdenada[j]) {
            cont++;
        }
    }
    console.log(cont);
}