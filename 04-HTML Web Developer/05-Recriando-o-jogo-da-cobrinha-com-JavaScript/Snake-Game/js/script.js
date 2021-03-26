let canvas = document.getElementById("snake");
let context = canvas.getContext("2d");
var circle;
let box = 32;
let direction = "right";

let snake = [];
snake[0] = {
    x: 8 * box,
    y: 8 * box,
}

let cor = {
    vermelho: "#E50914",
    preto: "#141414",
    cinza: "#A9A9A9",
    branco: "#FFFF"
}

let food = {
    x: Math.floor(Math.random() * 15 + 1) * box,
    y: Math.floor(Math.random() * 15 + 1) * box
}

function criarBG() {
    context.fillStyle = cor.branco;
    context.fillRect(0, 0, 16 * box, 16 * box);
}

function criarCobra() {
    for (let i = 0; i < snake.length; i++) {
        context.fillStyle = cor.preto;
        var circle = new Path2D();
        circle.moveTo(snake[i].x, snake[i].y, box, box);
        circle.arc(snake[i].x, snake[i].y, 15, 0, 2 * Math.PI);
        context.fill(circle);
    }
}

// criar comida
function drawFood() {
    context.fillStyle = cor.vermelho;
    circle = new Path2D();
    circle.moveTo(food.x, food.y, box, box);
    circle.arc(food.x, food.y, 12, 0, 2 * Math.PI);
    context.fill(circle);
}

// capturar dados do teclado
document.addEventListener('keydown', update);

function update(event) {
    if (event.keyCode == 37 && direction != "right") {
        direction = "left"
    }
    if (event.keyCode == 38 && direction != "down") {
        direction = "up"
    }
    if (event.keyCode == 39 && direction != "left") {
        direction = "right"
    }
    if (event.keyCode == 40 && direction != "up") {
        direction = "down"
    }
}

function movimentarCobra() {

    if (snake[0].x > 15 * box && direction == "right") {
        snake[0].x = 0;
    }
    if (snake[0].x < 0 && direction == "left") {
        snake[0].x = 16 * box;
    }
    if (snake[0].y > 15 * box && direction == "down") {
        snake[0].y = 0;
    }
    if (snake[0].y < 0 && direction == "up") {
        snake[0].y = 16 * box;
    }

}

function visualizarCobra() {

    let snakeX = snake[0].x;
    let snakeY = snake[0].y;

    //direção dentro do plano cartesiano
    if (direction == "right") {
        snakeX += box
    }
    if (direction == "left") {
        snakeX -= box
    }
    if (direction == "up") {
        snakeY -= box
    }
    if (direction == "down") {
        snakeY += box
    }

    //remove anterior para simular movimento 
    if (snakeX != food.x || snakeY != food.y) {
        snake.pop();
    } else {
        food.x = Math.floor(Math.random() * 15 + 1) * box;
        food.y = Math.floor(Math.random() * 15 + 1) * box;
    }

    // adiciona na frente para simular movimento 
    let newHead = {
        x: snakeX,
        y: snakeY
    }

    snake.unshift(newHead);

}

function iniciarJogo() {

    movimentarCobra();
    gameOver();
    criarBG();
    criarCobra();
    drawFood();
    visualizarCobra();

}

function gameOver() {
    for (let i = 1; i < snake.length; i++) {
        if (snake[0].x == snake[i].x && snake[0].y == snake[i].y) {
            clearInterval(jogo);
            alert("Fim de Jogo Cara!\nReinicie o navegador para recomeçar")
        }
    }
}
//Nível do Jogo
var nivel = prompt("Escolha Seu Nível\nFácil: 1\nMédio: 2\nDifícil: 3");

    if (nivel == 1) {
        nivelEscolhido = 120;
    }
    if (nivel == 2) {
        nivelEscolhido = 80;
    }
    if (nivel == 3) {
        nivelEscolhido = 40;
    }
    
let jogo = setInterval(iniciarJogo, nivelEscolhido);