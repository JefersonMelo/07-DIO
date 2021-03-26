var arr = new Array(5);
let par = 0;
let impar = 0;
let positivo = 0;
let negativo = 0;

for (let i = 0; i < arr.length; i++) {

    arr[i] = gets();

    if (arr[i] % 2 == 0) {
        par++;
    }
    if (arr[i] % 2 != 0) {
        impar++;
    }
    if (arr[i] > 0) {
        positivo++;
    }
    if (arr[i] < 0) {
        negativo++;
    }

}
console.log(par + " valor(es) par(es)");
console.log(impar + " valor(es) impar(es)");
console.log(positivo + " valor(es) positivo(s)");
console.log(negativo + " valor(es) negativo(s)");