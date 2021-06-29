package com.prospertec.diobank.teste

import com.prospertec.diobank.Pessoa

fun main() {
    val  p = Pessoa(nome = "Jef", cpf = "000.000.000-00")

    println("Nome: ${p.nome}\nCPF: ${p.cpf}")
}