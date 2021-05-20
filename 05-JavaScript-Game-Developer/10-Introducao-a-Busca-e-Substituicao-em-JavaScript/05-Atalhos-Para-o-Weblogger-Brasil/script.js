let text = gets();
const italics = /\_(.*?)\_/gim;
const bold = /\*(.*?)\*/gim;

function parseMarkdown(text) {
  const html = text.replace(italics, "<i>$1</i>").replace(bold, "<b>$1</b>");

  return html.trim();
}

let count = 0;

do {
  console.log(parseMarkdown(text));
  text = gets();
  count++;
} while (count < 60);
