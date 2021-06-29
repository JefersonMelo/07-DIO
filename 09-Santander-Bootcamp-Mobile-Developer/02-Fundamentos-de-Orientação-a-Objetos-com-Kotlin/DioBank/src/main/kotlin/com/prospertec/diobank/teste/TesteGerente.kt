package com.prospertec.diobank.teste

import com.prospertec.diobank.especialidade.Gerente

fun main() {
    val f = Gerente(nome = "Jeff", cpf = "222.222.222-22", salario = 15000.0, senha = "s123")

    println(f)

    TesteAuth().autent(f)
}

