function start() { // Inicio da função start()

    $("#inicio").hide();

    $("#fundo-game").append("<div id='jogador' class='animacao-resgate-aereo'></div>");
    $("#fundo-game").append("<div id='inimigo-aereo' class='animacao-inimigo-aereo'></div>");
    $("#fundo-game").append("<div id='inimigo-terrestre'></div>");
    $("#fundo-game").append("<div id='soldado' class='animacao-soldado'></div>");

    //Principais variáveis do jogo
    var jogo = {};

    //Game Loop
    jogo.timer = setInterval(loop, 30);

    function loop() {

        movefundo();

    } // Fim da função loop()

    //Função que movimenta o fundo do jogo
    function movefundo() {

        esquerda = parseInt($("#fundo-game").css("background-position"));
        $("#fundo-game").css("background-position", esquerda - 1);

    } // fim da função movefundo()

} // Fim da função start