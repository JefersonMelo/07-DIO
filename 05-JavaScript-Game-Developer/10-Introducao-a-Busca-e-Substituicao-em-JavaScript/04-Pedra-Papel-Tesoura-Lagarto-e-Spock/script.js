/*const input = require('fs').readFileSync('/dev/stdin', 'utf8');
const lines = input.split('\n');
https://www.devmedia.com.br/javascript-split-dividindo-separando-strings/39254
https://developer.mozilla.org/pt-BR/docs/Web/JavaScript/Reference/Global_Objects/String/split
https://digitalinnovation.one/artigos/operadores-if-else-switch-case-ternario-e-object-literals
*/
let dicionarioDeRegras = {
    tesoura: ['papel', 'lagarto'],
    papel: ['pedra', 'spock'],
    pedra: ['lagarto', 'tesoura'],
    lagarto: ['spock', 'papel'],
    spock: ['tesoura', 'pedra']
};

//finalize a declaração das jogadoras
let gamer_1 = 'fernanda';
let gamer_2 = 'marcia';

let resultado;

let N = parseInt(gets());

// continue a solução

for (let i = 0; i < N; i++) {

    let resposta = gets().split(' ');
    if (resposta[0] === resposta[1])
        resultado = 'empate';
    else
        resultado = (dicionarioDeRegras[resposta[0]].includes(resposta[1])) ? gamer_1: gamer_2;
    print(resultado);
}