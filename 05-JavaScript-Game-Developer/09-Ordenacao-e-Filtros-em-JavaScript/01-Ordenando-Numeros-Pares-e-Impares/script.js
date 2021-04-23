// a função gets é implementada dentro do sistema para ler as entradas(inputs) dos dados
// Abaixo segue um exemplo de código que você pode ou não utilizar

/*
  ## Arrays ##
  https://developer.mozilla.org/pt-BR/docs/Web/JavaScript/Reference/Global_Objects/Array

  ## concatenar arrays ##
  https://developer.mozilla.org/pt-BR/docs/Web/JavaScript/Reference/Global_Objects/Array/concat

  ## Ordenar Arrays ##
  https://developer.mozilla.org/pt-BR/docs/Web/JavaScript/Reference/Global_Objects/Array/sort
  https://ricardo-reis.medium.com/o-m%C3%A9todo-sort-do-array-javascript-482576734e0a


  ## Como Subir no URI
  https://pt.stackoverflow.com/questions/319010/como-ler-at%C3%A9-o-final-do-arquivo-com-javascript-uri-online-judge

*/

let totalitens = parseInt(gets());
let itens = [];
let pares = [];
let impares = [];

//ler todas as entradas
for (let i = 0; i < totalitens; i++) {
  itens.push(parseInt(gets()));
}

//separar em arrays de pares e impares
for (let i = 0; i < itens.length; i++) {
  if (itens[i] % 2 === 0) {
    pares[i] = itens[i];
  } else {
    impares[i] = itens[i];
  }
}

//ordenar em order crescente
pares.sort(function(a, b) {
  return a - b;
});

//ordenar em ordem decrescente
impares.sort(function(a, b) {
  return b - a;
});

//concatenar os arrays
let arrayConcat = pares.concat(impares);

for (const num of arrayConcat) {
  console.log(num);
}

