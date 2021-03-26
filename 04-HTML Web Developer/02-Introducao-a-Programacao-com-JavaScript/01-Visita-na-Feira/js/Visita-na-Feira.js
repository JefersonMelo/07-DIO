var line = prompt("Valor").split(" ");

function soma(line) {
    var A = parseInt(line[0]);
    var B = parseInt(line[1]);
    let total = A + B; // Altere o valor da variável com o cálculo esperado
    return total; 
}

function resposta() {
    document.getElementById("resposta").innerHTML = soma(line);
}