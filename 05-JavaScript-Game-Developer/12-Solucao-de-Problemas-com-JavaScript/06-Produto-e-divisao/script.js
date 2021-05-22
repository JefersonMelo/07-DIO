let input, number1, number2, operator, result;
const regexInput = /^([0-9]) *([*/])/

const doMath = {
  '/': (a, b) => {
    a = Number(a)
    b = Number(b)
    return parseFloat(a / b)
  },
  '*': (a, b) => {
    if (Number(a) * Number(b) >= Number.MAX_SAFE_INTEGER) {
      a = BigInt(a)
      b = BigInt(b)
      return a * b
    }
    return a * b
  }
}

while (true) {
  number1 = 1
  number2 = undefined
  result = undefined
  input = undefined
  operator = undefined
  nOperators = parseInt(gets())

  if (!nOperators || nOperators === '' || nOperators < 1 || nOperators > 100000) break;

  for (let index = 0; index < nOperators; index++) {
    input = gets();

    if (!input.match(regexInput)) continue;
    [str, number2, operator] = input.match(regexInput);

    if (number2 === undefined || (number2 == 0 && operator === '/')) continue;
    result = doMath[operator](number1, number2)
    number1 = result
  }

  if (result === undefined) { console.log(number1); continue; }
  console.log(typeof result == 'bigint' ? result.toString() : parseInt(result))
}