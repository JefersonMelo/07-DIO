/**
 * https://developer.mozilla.org/pt-BR/docs/Web/JavaScript/Reference/Global_Objects/Array
 * 
 * https://www.devmedia.com.br/criando-uma-lista-generica-de-objetos-no-javascript/25564
 * 
 * https://developer.mozilla.org/pt-BR/docs/Web/JavaScript/Guide/Indexed_Collections
 * 
 * https://bognarjunior.wordpress.com/2018/01/24/fila-e-pilha-com-javascript/
 * 
 * https://developer.mozilla.org/pt-BR/docs/Web/JavaScript/Reference/Functions/Arrow_functions
 * 
 */

let n = parseInt(gets());

let camisetas = Array(n);

for (let i = 0; i < camisetas.length; i++) {
    let id = gets();
    let entrada = gets().split(" ");
    camisetas[i] = {
        cor: entrada[0],
        tamanho: entrada[1],
        nomePessoa: id,
    };
}

camisetas.sort((a, b) => a.nomePessoa > b.nomePessoa ? 1 : -1);
camisetas.sort((a, b) => b.tamanho < a.tamanho ? 1 : -1);
camisetas.sort((a, b) => a.cor > b.cor ? 1 : -1);

camisetas.forEach(item => console.log(Object.values(item).join(" ")));