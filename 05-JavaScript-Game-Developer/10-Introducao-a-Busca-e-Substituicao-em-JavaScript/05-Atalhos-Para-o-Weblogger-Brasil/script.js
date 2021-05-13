const input = require('fs').readFileSync('/dev/stdin', 'utf8');
const lines = input.split('\n');

while (true) {
  let string = lines.shift();

  if (!string) {
    break;
  }

  const letters = string.split("");
  const formattedLetters = letters;

  let searchingItalicEndTag = false;
  let searchingBoldEndTag = false;

  for (let i = 0; i < letters.length; i++) {
   //continue a solução 

    if (letter === "_") {
      formattedLetters[i] = searchingItalicEndTag
       //continue a solução 

    } else if (letter === "*") {
    //continue a solução 
    }
  }
  
  console.log(formattedLetters.join(""));
}