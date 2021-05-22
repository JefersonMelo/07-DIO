let vogaisAlien = '';
let expressao = '';
const alfabeto = /[^A-Za-z0-9 ]/g;

while (true) {
  vogaisAlien = gets()
  
  if (!vogaisAlien || vogaisAlien === '') {break;}
  vogaisAlien = vogaisAlien.replace(/ /g, '');
  expressao = gets();

  if (alfabeto.test(vogaisAlien) || alfabeto.test(expressao)) {continue;}
  console.log(contador(vogaisAlien, expressao));
}

function contador(letra, frase) {
  return letra.split('').reduce((qtdLetra, caracter) => {
    qtdLetra += (frase || '').match(new RegExp(`${caracter}`, 'g'))?.length || 0
    return qtdLetra
  }, 0)
}