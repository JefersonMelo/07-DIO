// a função gets é implementada dentro do sistema para ler as entradas(inputs) dos dados
let totalItems = gets();

for (var i = 0; i < totalItems; i++) {
  let itens = gets();
  let itensOrdenados = itens.split(" ").sort();
  let itensUnicos = itensOrdenados; // Implemente aqui a lógica para ter os itens unicos
  let resposta = [...itensUnicos].join(" ");
  console.log(resposta);
}