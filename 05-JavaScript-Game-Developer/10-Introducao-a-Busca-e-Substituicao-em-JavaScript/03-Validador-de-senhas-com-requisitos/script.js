function validadorDeSenha(senha) {
    return /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z])(?!.*[_])\w{6,32}$/.test(senha)
  }
  
  var senha = "";
  
  do {
    senha = gets();
    if (senha !== "") {
      var valido = validadorDeSenha(senha);
      console.log("Senha " + (valido ? "valida." : "invalida."));
    }
  } while (senha !== "");