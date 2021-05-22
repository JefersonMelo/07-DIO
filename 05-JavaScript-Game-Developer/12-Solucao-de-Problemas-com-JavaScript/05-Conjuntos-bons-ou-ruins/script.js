let N;
const limit = Math.pow(10, 5);
let words, isBad;

while (true) {
  words = []
  N = parseInt(gets())
  
  if (N === 0 || (N < 1 || N > limit)) break;

  for (let index = 0; index < N; index++) {
    word = gets()
    if (!(/^[a-z]{1,100}$/g.test(word))) continue;

    words = [...words, word]
  }

  isBad = words.some((currentWord, i, words) => {
    const pattern = new RegExp(`^(${currentWord}).+`)

    for (const word of words) {
      if (pattern.test(word)) return true
    }

    const same = words.reduce((total, w) => {
      total += w === currentWord ? 1 : 0
      return total
    }, 0)

    return same > 1;
  })
  console.log(isBad ? 'Conjunto Ruim' : 'Conjunto Bom');
}