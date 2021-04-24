// a função gets é implementada dentro do sistema para ler as entradas(inputs) dos dados
let totalItens = parseInt(gets());
/*
https://medium.com/trainingcenter/javascript-removendo-valores-duplicados-de-um-array-36e30e3d44c2
https://pt.stackoverflow.com/questions/16483/remover-elementos-repetido-dentro-de-um-array-em-javascript
*/
for (var i = 0; i < totalItens; i++) {
  let itens = gets();
  let itensOrdenados = itens.split(" ").sort();
  let itensUnicos = [...new Set(itensOrdenados)]; // Implemente aqui a lógica para ter os itens unicos
  let resposta = [...itensUnicos].join(" ");
  console.log(resposta);
}
