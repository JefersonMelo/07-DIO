const input = require('fs').readFileSync('/dev/stdin', 'utf8');
const lines = input.split('\n');

let dicionarioDeRegras = {
    tesoura: ['papel','lagarto'],
    papel: ['pedra','spock'],
    pedra: ['lagarto','tesoura'],
    lagarto: ['spock','papel'],
    spock: ['tesoura','pedra']
};

//finalize a declaração das jogadoras
let  = 'fernanda';
let  = 'marcia';

let resultado;

let N = parseInt(gets());

// continue a solução

for(   ){

let     = gets().split(' ');
if(   ===  )
resultado = 'empate';
else
resultado = (dicionarioDeRegras[     .includes(  ] ) ) ?   :    ;

print(resultado);
}