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
    var fimdejogo = false;
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
        var colisaoInimigoTerrestre = ($("#jogador").collision($("#inimigo-terrestre")));
        var colisaoDisparoAereo = ($("#disparo").collision($("#inimigo-aereo")));
        var colisaoDisparoTerrestre = ($("#disparo").collision($("#inimigo-terrestre")));
        var colisaoInimigoTerrestreSoldado = ($("#jogador").collision($("#soldado")));
        var colisao6 = ($("#inimigo-terrestre").collision($("#soldado")));

        // Colisão jogador com o inimigo-aereo
        if (colisaoInimigoAereo.length > 0) {

            inimigoAereoX = parseInt($("#inimigo-aereo").css("left"));
            inimigoAereoY = parseInt($("#inimigo-aereo").css("top"));
            explosaoInimigoAereo(inimigoAereoX, inimigoAereoY);

            posicaoY = parseInt(Math.random() * 334);
            $("#inimigo-aereo").css("left", 694);
            $("#inimigo-aereo").css("top", posicaoY);
        }

        // Colisão jogador com o inimigo2 
        if (colisaoInimigoTerrestre.length > 0) {

            InimigoTerrestreX = parseInt($("#inimigo-terrestre").css("left"));
            InimigoTerrestreY = parseInt($("#inimigo-terrestre").css("top"));
            explosaoInimigoTerrestre(InimigoTerrestreX, InimigoTerrestreY);

            $("#inimigo-terrestre").remove();

            reposicionaInimigoTerresre();

        }

        // Colisão Disparo com o inimigo1
        if (colisaoDisparoAereo.length > 0) {

            InimigoAereoX = parseInt($("#inimigo-aereo").css("left"));
            InimigoAereoY = parseInt($("#inimigo-aereo").css("top"));

            explosao1(InimigoAereoX, InimigoAereoY);
            $("#disparo").css("left", 950);

            posicaoY = parseInt(Math.random() * 334);
            $("#inimigo-aereo").css("left", 694);
            $("#inimigo-aereo").css("top", posicaoY);

        }

        // Disparo com o inimigo2
        if (colisaoDisparoTerrestre.length > 0) {

            InimigoTerrestreX = parseInt($("#inimigo-terrestre").css("left"));
            InimigoTerrestreY = parseInt($("#inimigo-terrestre").css("top"));
            $("#inimigo-terrestre").remove();

            explosaoInimigoTerrestre(InimigoTerrestreX, InimigoTerrestreY);
            $("#disparo").css("left", 950);

            reposicionaInimigoTerresre();

        }

        // jogador com o amigo
        if (colisaoInimigoTerrestreSoldado.length > 0) {

            reposicionaSoldado();
            $("#soldado").remove();

        }


    } //Fim da função colisao()

    //Explosão 1
    function explosaoInimigoAereo(inimigoAereoX, inimigoAereoY) {

        $("#fundo-game").append("<div id='explosaoInimigoAereo'></div");
        $("#explosaoInimigoAereo").css("background-image", "url(img/explosao.png)");
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

    //Explosão2
    function explosaoInimigoTerrestre(InimigoTerrestreX, InimigoTerrestreY) {

        $("#fundo-game").append("<div id='explosaoInimigoTerrestre'></div");
        $("#explosaoInimigoTerrestre").css("background-image", "url(img/explosao.png)");
        var div2 = $("#explosaoInimigoTerrestre");
        div2.css("top", InimigoTerrestreY);
        div2.css("left", InimigoTerrestreX);
        div2.animate({
            width: 200,
            opacity: 0
        }, "slow");

        var tempoexplosaoInimigoTerrestre = window.setInterval(removeexplosaoInimigoTerrestre, 1000);

        function removeexplosaoInimigoTerrestre() {

            div2.remove();
            window.clearInterval(tempoexplosaoInimigoTerrestre);
            tempoexplosaoInimigoTerrestre = null;

        }

    } // Fim da função explosaoInimigoTerrestre()


    //Reposiciona Inimigo2
    function reposicionaInimigoTerresre() {

        var tempocolisaoDisparoTerrestre = window.setInterval(reposiciona4, 5000);

        function reposiciona4() {
            window.clearInterval(tempocolisaoDisparoTerrestre);
            tempocolisaoDisparoTerrestre = null;

            if (fimdejogo == false) {

                $("#fundo-game").append("<div id=inimigo2></div");

            }

        }

    } // Fim da função reposicionaInimigoTerresre()

    //Reposiciona Amigo
    function reposicionaSoldado() {

        var tempoAmigo = window.setInterval(reposiciona6, 6000);

        function reposiciona6() {
            window.clearInterval(tempoAmigo);
            tempoAmigo = null;

            if (fimdejogo == false) {

                $("#fundo-game").append("<div id='soldado' class='anima3'></div>");

            }

        }

    } // Fim da função reposicionaSoldado()


} // Fim da função start