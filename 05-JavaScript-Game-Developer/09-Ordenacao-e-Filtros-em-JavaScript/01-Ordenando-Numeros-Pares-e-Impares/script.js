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

  ## Depurar No Mozilla ##
  https://www.devmedia.com.br/depurando-javascript-no-mozilla-firefox/28387
*/

let qtdEntradas = parseInt(gets());
let nums = 0;

let pares = [];
let impares = [];

//ler todas as entradas
for (let i = 0; i < qtdEntradas; i++) {
  nums = parseInt(gets());

  if (nums >= 0) {
    if (nums % 2 === 0) {
      pares[i] = nums;
    } else {
      impares[i] = nums;
    }
  }
}

//ordenar crescente
pares.sort(function (a, b) {
  return a - b;
});

//ordenar decrescente
impares.sort(function (a, b) {
  return b - a;
});

//concatenar os arrays
let arrayConcat = pares.concat(impares);

//Impressão um por linha
arrayConcat.forEach(i => {
  console.log(i)
});