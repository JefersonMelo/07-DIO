var size = gets();
var line = "";
var palavras = [];
var newLine = "";

if (size <= 50) {
  for (i = 0; i < size; i++) {
    line = gets();
    palavras = line.split(" ");
    palavras.sort((a, b) => b.length - a.length || a.localeCompare(b));
    newLine = palavras.join(" ");
    console.log(newLine);
  }
}
