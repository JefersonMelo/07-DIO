let input = '';
let resultados;
let limite = 0;

while (true) {
  input = gets()

  if (!input || input === '' || input.length > 30) break;

  limite = -Math.floor(input.length / 2)
  resultados = []

  for (let index = -1; index >= limite; index--) {
    input.slice(index) === input.slice(index * 2, index) && resultados.push(input.slice(0, index))
  }

  if (!resultados || resultados.length === 0) {
    console.log(input)
    continue;
  }

  for (const result of resultados.sort()) {
    console.log(result)
  }
}