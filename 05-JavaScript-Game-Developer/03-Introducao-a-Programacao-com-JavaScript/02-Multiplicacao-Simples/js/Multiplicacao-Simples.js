var valor1 = prompt("Valor 1");
var valor2 = prompt("Valor 2");
console.log("PROD = " + total);

function multiplicacao(valor1, valor2) {
    var total = valor1 * valor2; // Altere o valor da variável com o cálculo esperado 
    return total;
}

function resposta() {
    document.getElementById("resposta").innerHTML = "PROD = " + multiplicacao(valor1, valor2);
}