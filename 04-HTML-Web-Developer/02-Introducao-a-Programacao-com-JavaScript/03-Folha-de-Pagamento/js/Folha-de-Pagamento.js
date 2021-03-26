var valor1 = prompt("Valor 1");
var valor2 = prompt("Valor 2");
var valor3 = prompt("Valor 3");
var salary;

function valorSalario(valor2, valor3) {
    return salary = parseFloat(valor2 * valor3).toFixed(2);// Digite aqui o calculo do salário
}
function resposta() {
    document.getElementById("resposta").innerHTML = "NUMBER = " + valor1 + "\nSALARY = U$ " + valorSalario(valor2, valor3);
}
console.log("NUMBER = " + valor1);
console.log("SALARY = U$ " + salary);