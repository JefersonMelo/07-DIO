function start() { // Inicio da função start()

    $("#inicio").hide();

    $("#fundo-game").append("<div id='jogador' class='animacao-resgate-aereo'></div>");
    $("#fundo-game").append("<div id='inimigo-aereo' class='animacao-inimigo-aereo'></div>");
    $("#fundo-game").append("<div id='inimigo-terrestre'></div>");
    $("#fundo-game").append("<div id='soldado' class='animacao-soldado'></div>");
    $("#fundo-game").append("<div id='placar'></div>");
    $("#fundo-game").append("<div id='energia'></div>");


    //Principais variáveis do jogo
    var jogo = {};
    var terrestre;
    var velocidade = 5;
    var energiaAtual = 3;
    var pontos = 0;
    var salvos = 0;
    var perdidos = 0;
    var podeAtirar = true;
    var fimdejogo = false;
    var posicaoY = parseInt(Math.random() * 334);
    var Tecla = {
        SetaCima: 38,
        SetaBaixo: 40,
        D: 68
    }
    jogo.pressionou = [];
    var somDisparo = document.getElementById("somDisparo");
    var somExplosao = document.getElementById("somExplosao");
    var musica = document.getElementById("musica");
    var somGameover = document.getElementById("somGameover");
    var somPerdido = document.getElementById("somPerdido");
    var somResgate = document.getElementById("somResgate");
    //Música em loop
    musica.addEventListener("ended", function () {
        musica.currentTime = 0;
        musica.play();
    }, false);
    musica.play();

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
        placar();
        energia();

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
        var resgateSoldado = ($("#jogador").collision($("#soldado")));
        var colisaoInimigoTerrestreSoldado = ($("#inimigo-terrestre").collision($("#soldado")));

        // Colisão jogador com o inimigo-aereo
        if (colisaoInimigoAereo.length > 0) {

            somExplosao.play();

            /*Perca de Energia por colisão*/
            energiaAtual--;

            inimigoAereoX = parseInt($("#inimigo-aereo").css("left"));
            inimigoAereoY = parseInt($("#inimigo-aereo").css("top"));
            explosaoInimigoAereo(inimigoAereoX, inimigoAereoY);

            posicaoY = parseInt(Math.random() * 334);
            $("#inimigo-aereo").css("left", 694);
            $("#inimigo-aereo").css("top", posicaoY);
        }

        // Colisão jogador com o inimigo2 
        if (colisaoInimigoTerrestre.length > 0) {

            somExplosao.play();

            /*Perca de Energia por colisão*/
            energiaAtual--;

            InimigoTerrestreX = parseInt($("#inimigo-terrestre").css("left"));
            InimigoTerrestreY = parseInt($("#inimigo-terrestre").css("top"));
            explosaoInimigoTerrestre(InimigoTerrestreX, InimigoTerrestreY);

            $("#inimigo-terrestre").remove();

            reposicionaInimigoTerresre();

        }

        // Colisão Disparo com o inimigo1
        if (colisaoDisparoAereo.length > 0) {

            /*Pontos Por Abater Inimigo Aéreo*/
            pontos = pontos + 100;

            InimigoAereoX = parseInt($("#inimigo-aereo").css("left"));
            InimigoAereoY = parseInt($("#inimigo-aereo").css("top"));

            explosaoInimigoAereo(InimigoAereoX, InimigoAereoY);
            $("#disparo").css("left", 950);

            posicaoY = parseInt(Math.random() * 334);
            $("#inimigo-aereo").css("left", 694);
            $("#inimigo-aereo").css("top", posicaoY);

        }

        // Disparo com o inimigo2
        if (colisaoDisparoTerrestre.length > 0) {

            /*Pontos Por Abater Inimigo Terrestre*/
            pontos = pontos + 50;

            InimigoTerrestreX = parseInt($("#inimigo-terrestre").css("left"));
            InimigoTerrestreY = parseInt($("#inimigo-terrestre").css("top"));
            $("#inimigo-terrestre").remove();

            explosaoInimigoTerrestre(InimigoTerrestreX, InimigoTerrestreY);
            $("#disparo").css("left", 950);

            reposicionaInimigoTerresre();

            /* Aumento da dificuldade Por Apelar Matando Apenas Terrestre*/
            if (terrestre < 3) {
                terrestre++;
                velocidade = velocidade + 0.8;
            } else {
                terrestre = 0;
            }

        }

        // jogador com o amigo
        if (resgateSoldado.length > 0) {

            somResgate.play();

            /*Soldados Salvos*/
            salvos++;

            reposicionaSoldado();
            $("#soldado").remove();

            /* Aumento da dificuldade */
            velocidade = velocidade + 0.3;

        }

        //Inimigo2 com o soldado
        if (colisaoInimigoTerrestreSoldado.length > 0) {

            somPerdido.play();

            /*Soldados Mortos Por Atropelamento*/
            perdidos++;

            soldadoX = parseInt($("#soldado").css("left"));
            soldadoY = parseInt($("#soldado").css("top"));
            explosaoSoldado(soldadoX, soldadoY);
            $("#soldado").remove();

            reposicionaSoldado();

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

        var divInimigoTerrestre = $("#explosaoInimigoTerrestre");
        divInimigoTerrestre.css("top", InimigoTerrestreY);
        divInimigoTerrestre.css("left", InimigoTerrestreX);
        divInimigoTerrestre.animate({
            width: 200,
            opacity: 0
        }, "slow");

        var tempoexplosaoInimigoTerrestre = window.setInterval(removeexplosaoInimigoTerrestre, 1000);

        function removeexplosaoInimigoTerrestre() {

            divInimigoTerrestre.remove();
            window.clearInterval(tempoexplosaoInimigoTerrestre);
            tempoexplosaoInimigoTerrestre = null;

        }

    } // Fim da função explosaoInimigoTerrestre()


    //Reposiciona Inimigo2
    function reposicionaInimigoTerresre() {

        var tempocolisaoDisparoTerrestre = window.setInterval(reposicionaTerrestre, 5000);

        function reposicionaTerrestre() {

            window.clearInterval(tempocolisaoDisparoTerrestre);
            tempocolisaoDisparoTerrestre = null;

            if (fimdejogo == false) {

                $("#fundo-game").append("<div id=inimigo-terrestre></div");

            }

        }

    } // Fim da função reposicionaInimigoTerresre()

    //Reposiciona Amigo
    function reposicionaSoldado() {

        var tempoSoldado = window.setInterval(reposicionandoSoldado, 6000);

        function reposicionandoSoldado() {

            window.clearInterval(tempoSoldado);
            tempoSoldado = null;

            if (fimdejogo == false) {

                $("#fundo-game").append("<div id='soldado' class='animacao-soldado'></div>");

            }

        }

    } // Fim da função reposicionaSoldado()

    //Explosão3
    function explosaoSoldado(soldadoX, soldadoY) {

        $("#fundo-game").append("<div id='explosao-soldado' class='animacaoAtropeloSoldado'></div");
        $("#explosao-soldado").css("top", soldadoY);
        $("#explosao-soldado").css("left", soldadoX);

        var tempoExplosaoSoldado = window.setInterval(resetaexplosaoSoldado, 1000);

        function resetaexplosaoSoldado() {

            $("#explosao-soldado").remove();
            window.clearInterval(tempoExplosaoSoldado);
            tempoExplosaoSoldado = null;

        }

    } // Fim da função explosaoSoldado

    function placar() {

        $("#placar").html("<h2> Pontos: " + pontos + " Salvos: " + salvos + " Perdidos: " + perdidos + "</h2>");

    } //fim da função placar()

    function energia() {

        if (energiaAtual == 3) {

            $("#energia").css("background-image", "url(img/energia3.png)");
        }

        if (energiaAtual == 2) {

            $("#energia").css("background-image", "url(img/energia2.png)");
        }

        if (energiaAtual == 1) {

            $("#energia").css("background-image", "url(img/energia1.png)");
        }

        if (energiaAtual == 0) {

            $("#energia").css("background-image", "url(img/energia0.png)");

            //Game Over
        }

    } // Fim da função energia()


} // Fim da função start