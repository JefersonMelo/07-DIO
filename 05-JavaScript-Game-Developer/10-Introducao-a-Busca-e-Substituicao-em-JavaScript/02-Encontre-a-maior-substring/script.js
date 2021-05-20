const input = require('fs').readFileSync('/dev/stdin', 'utf8');
const lines = input.split('\n');

let string1 = gets();
let string2 = gets();

while (string1 !== "") {
  if (string1.length >= string2.length) {
    countChar(string2, string1);
  } else {
    countChar(string1, string2);
  }
  string1 = gets();
  string2 = gets();
}

function countChar(menorString, maiorString) {
  let count = 0;

  for (let i = 0; i <= maiorString.length; i++) {
    for (let j = 0; j < maiorString.length; j++) {
      let subString = maiorString.substring(i, j);
      
      if (menorString.includes(subString) && subString.length > count) {
        count = subString.length;
      }
    }
  }
  console.log(count);
}