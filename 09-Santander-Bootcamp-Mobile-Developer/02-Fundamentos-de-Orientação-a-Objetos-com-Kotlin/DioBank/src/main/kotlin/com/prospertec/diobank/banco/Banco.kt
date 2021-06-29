package com.prospertec.diobank.banco

data class Banco(
    val nome: String,
    val num: Int,
    val endereco: String
) {
    fun info() = "Nome: $nome\n " +
            "Número: $num\n " +
            "Endereço: $endereco"
}
