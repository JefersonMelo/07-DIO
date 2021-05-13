var jogador, vencedor = null;
var jogadorSelecionado = document.getElementById('jogador-selecionado');
var vencedorSelecionado = document.getElementById('vencedor-selecionado');

MudarJogador('X');

function EscolherQuadrado(id) {
    if (vencedor !== null) {
        return;
    }

    var quadrado = document.getElementById(id);
    if (quadrado.innerHTML !== '-') {
        return;
    }

    quadrado.innerHTML = jogador;
    quadrado.style.color = '#000';

    if (jogador === 'X') {
        jogador = 'O';
    } else {
        jogador = 'X';
    }

    MudarJogador(jogador);
    ChecaVencedor();
}

function MudarJogador(valor) {
    jogador = valor;
    jogadorSelecionado.innerHTML = jogador;
}

function ChecaVencedor() {
    var quadrado1 = document.getElementById(1);
    var quadrado2 = document.getElementById(2);
    var quadrado3 = document.getElementById(3);
    var quadrado4 = document.getElementById(4);
    var quadrado5 = document.getElementById(5);
    var quadrado6 = document.getElementById(6);
    var quadrado7 = document.getElementById(7);
    var quadrado8 = document.getElementById(8);
    var quadrado9 = document.getElementById(9);

    if (ChecaSequencia(quadrado1, quadrado2, quadrado3)) {
        MudaCorQuadrado(quadrado1, quadrado2, quadrado3);
        MudarVencedor(quadrado1);
        return;
    }

    if (ChecaSequencia(quadrado4, quadrado5, quadrado6)) {
        MudaCorQuadrado(quadrado4, quadrado5, quadrado6);
        MudarVencedor(quadrado4);
        return;
    }

    if (ChecaSequencia(quadrado7, quadrado8, quadrado9)) {
        MudaCorQuadrado(quadrado7, quadrado8, quadrado9);
        MudarVencedor(quadrado7);
        return;
    }

    if (ChecaSequencia(quadrado1, quadrado4, quadrado7)) {
        MudaCorQuadrado(quadrado1, quadrado4, quadrado7);
        MudarVencedor(quadrado1);
        return;
    }

    if (ChecaSequencia(quadrado2, quadrado5, quadrado8)) {
        MudaCorQuadrado(quadrado2, quadrado5, quadrado8);
        MudarVencedor(quadrado2);
        return;
    }

    if (ChecaSequencia(quadrado3, quadrado6, quadrado9)) {
        MudaCorQuadrado(quadrado3, quadrado6, quadrado9);
        MudarVencedor(quadrado3);
        return;
    }

    if (ChecaSequencia(quadrado1, quadrado5, quadrado9)) {
        MudaCorQuadrado(quadrado1, quadrado5, quadrado9);
        MudarVencedor(quadrado1);
        return;
    }

    if (ChecaSequencia(quadrado3, quadrado5, quadrado7)) {
        MudaCorQuadrado(quadrado3, quadrado5, quadrado7);
        MudarVencedor(quadrado3);
    }
}

function MudarVencedor(quadrado) {
    vencedor = quadrado.innerHTML;
    vencedorSelecionado.innerHTML = vencedor;
}

function MudaCorQuadrado(quadrado1, quadrado2, quadrado3) {
    quadrado1.style.background = '#2ab101d0';
    quadrado2.style.background = '#2ab101d0';
    quadrado3.style.background = '#2ab101d0';
}

function ChecaSequencia(quadrado1, quadrado2, quadrado3) {
    var eigual = false;

    if (quadrado1.innerHTML !== '-' && quadrado1.innerHTML === quadrado2.innerHTML && quadrado2.innerHTML === quadrado3.innerHTML) {
        eigual = true;
    }

    return eigual;
}

function Reiniciar()
{
    vencedor = null;
    vencedorSelecionado.innerHTML = '';

    for (var i = 1; i <= 9; i++) {
        var quadrado = document.getElementById(i);
        quadrado.style.background = '#FFFF';
        quadrado.style.color = '#FFFF';
        quadrado.innerHTML = '-';
    }

    MudarJogador('X');
}
