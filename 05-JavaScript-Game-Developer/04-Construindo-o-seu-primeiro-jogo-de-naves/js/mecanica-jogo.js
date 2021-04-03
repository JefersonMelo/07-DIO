function start() { // Inicio da função start()

    $("#inicio").hide();

    $("#fundo-game").append("<div id='jogador' class='animacao-resgate-aereo'></div>");
    $("#fundo-game").append("<div id='inimigo-aereo' class='animacao-inimigo-aereo'></div>");
    $("#fundo-game").append("<div id='inimigo-terrestre'></div>");
    $("#fundo-game").append("<div id='soldado' class='animacao-soldado'></div>");

    //Principais variáveis do jogo
    var jogo = {};
    var velocidade = 5;
    var podeAtirar = true;
    var posicaoY = parseInt(Math.random() * 334);
    var Tecla = {
        SetaCima: 38,
        SetaBaixo: 40,
        D: 68
    }

    jogo.pressionou = [];

    //Verifica se o usuário pressionou alguma Tecla	
    $(document).keydown(function (e) {
        jogo.pressionou[e.which] = true;
    });


    $(document).keyup(function (e) {
        jogo.pressionou[e.which] = false;
    });

    //Game Loop
    jogo.timer = setInterval(loop, 30);

    function loop() {

        movefundo();
        movejogador();
        moveInimigoAereo();
        moveInimigoTerrestre();
        moveSoldado();
        colisao();

    } // Fim da função loop()

    //Função que movimenta o fundo do jogo
    function movefundo() {

        esquerda = parseInt($("#fundo-game").css("background-position"));
        $("#fundo-game").css("background-position", esquerda - 1);

    } // fim da função movefundo()

    function movejogador() {

        if (jogo.pressionou[Tecla.SetaCima]) {

            var topo = parseInt($("#jogador").css("top"));
            $("#jogador").css("top", topo - 10);

            //limita o jogadador não ultrapassar tela superior
            if (topo <= 0) {

                $("#jogador").css("top", topo + 10);
            }

        }

        if (jogo.pressionou[Tecla.SetaBaixo]) {

            var topo = parseInt($("#jogador").css("top"));
            $("#jogador").css("top", topo + 10);

            //limita o jogadador não ultrapassar tela inferior
            if (topo >= 434) {
                $("#jogador").css("top", topo - 10);

            }

        }

        if (jogo.pressionou[Tecla.D]) {

            //Chama função Disparo
            disparo();
        }

    } // fim da função movejogador()

    function moveInimigoAereo() {

        posicaoX = parseInt($("#inimigo-aereo").css("left"));
        $("#inimigo-aereo").css("left", posicaoX - velocidade);
        $("#inimigo-aereo").css("top", posicaoY);

        if (posicaoX <= 0) {

            posicaoY = parseInt(Math.random() * 334);
            $("#inimigo-aereo").css("left", 694);
            $("#inimigo-aereo").css("top", posicaoY);

        }

    } //Fim da função moveInimigoAereo()

    function moveInimigoTerrestre() {

        posicaoX = parseInt($("#inimigo-terrestre").css("left"));
        $("#inimigo-terrestre").css("left", posicaoX - 3);

        if (posicaoX <= 0) {

            $("#inimigo-terrestre").css("left", 775);

        }

    } // Fim da função moveinimigo-terrestre()

    function moveSoldado() {

        posicaoX = parseInt($("#soldado").css("left"));
        $("#soldado").css("left", posicaoX + 1);

        if (posicaoX > 906) {

            $("#soldado").css("left", 0);

        }

    } // fim da função moveSoldado()

    function disparo() {

        if (podeAtirar == true) {

            podeAtirar = false;

            topo = parseInt($("#jogador").css("top"))
            posicaoX = parseInt($("#jogador").css("left"))
            tiroX = posicaoX + 185;
            topoTiro = topo + 50;
            $("#fundo-game").append("<div id='disparo'></div");
            $("#disparo").css("top", topoTiro);
            $("#disparo").css("left", tiroX);

            var tempoDisparo = window.setInterval(executaDisparo, 30);

        } //Fecha podeAtirar

        function executaDisparo() {

            posicaoX = parseInt($("#disparo").css("left"));
            $("#disparo").css("left", posicaoX + 15);

            if (posicaoX > 900) {

                window.clearInterval(tempoDisparo);
                tempoDisparo = null;
                $("#disparo").remove();
                podeAtirar = true;

            }

        } // Fecha executaDisparo()

    } // Fecha disparo()

    function colisao() {

        var colisaoInimigoAereo = ($("#jogador").collision($("#inimigo-aereo")));
        // jogador com o inimigo-aereo

        if (colisaoInimigoAereo.length > 0) {

            inimigoAereoX = parseInt($("#inimigo-aereo").css("left"));
            inimigoAereoY = parseInt($("#inimigo-aereo").css("top"));
            explosaoInimigoAereo(inimigoAereoX, inimigoAereoY);

            posicaoY = parseInt(Math.random() * 334);
            $("#inimigo-aereo").css("left", 694);
            $("#inimigo-aereo").css("top", posicaoY);
        }

    } //Fim da função colisao()

    //Explosão 1
    function explosaoInimigoAereo(inimigoAereoX, inimigoAereoY) {

        $("#fundo-game").append("<div id='explosaoInimigoAereo'></div");
        $("#explosaoInimigoAereo").css("background-image", "url(../img/explosao.png)");
        var div = $("#explosaoInimigoAereo");
        div.css("top", inimigoAereoY);
        div.css("left", inimigoAereoX);
        div.animate({
            width: 200,
            opacity: 0
        }, "slow");

        var tempoExplosao = window.setInterval(removeExplosao, 1000);

        function removeExplosao() {

            div.remove();
            window.clearInterval(tempoExplosao);
            tempoExplosao = null;

        }

    } // Fim da função explosaoInimigoAereo()

} // Fim da função start