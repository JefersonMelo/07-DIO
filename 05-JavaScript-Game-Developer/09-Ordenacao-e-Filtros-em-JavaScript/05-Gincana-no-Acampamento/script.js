// a função gets é implementada dentro do sistema para ler as entradas(inputs) dos dados
quantAlunos = gets();

while (quantAlunos > 0) {
    listaAlunos = [];
    for (i = 1; i <= quantAlunos; i++) {
        arrayAux = gets().split(' ');
        listaAlunos.push({
            nome: arrayAux[0],
            valor: parseInt(arrayAux[1])
        });
    }
    contadorValorFicha = 0;
    valorFicha = listaAlunos[0].valor;
    while ((arrQuantAlunoPorGrupo = listaAlunos.length) > 1) {
        (valorFicha % 2 == 1) ?
        contadorValorFicha = (contadorValorFicha + valorFicha) % arrQuantAlunoPorGrupo:
            contadorValorFicha = (contadorValorFicha - (valorFicha % arrQuantAlunoPorGrupo)) % arrQuantAlunoPorGrupo;
        if (contadorValorFicha < 0) contadorValorFicha = arrQuantAlunoPorGrupo + contadorValorFicha;
        valorFicha = listaAlunos[contadorValorFicha].valor;
        listaAlunos.splice(contadorValorFicha, 1);
        if (valorFicha % 2 == 1) contadorValorFicha--;
        arrQuantAlunoPorGrupo--;
    }
    console.log("Vencedor(a): " + listaAlunos[0].nome);
    quantAlunos = gets();
}