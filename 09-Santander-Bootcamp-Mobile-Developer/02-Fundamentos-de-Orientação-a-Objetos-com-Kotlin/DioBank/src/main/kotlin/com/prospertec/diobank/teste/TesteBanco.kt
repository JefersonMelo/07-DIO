package com.prospertec.diobank.teste

import com.prospertec.diobank.Banco

fun main() {
    val bank = Banco(nome = "DioBank", num = 1, endereco = "web")
    println(bank.info())
}