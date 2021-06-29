package com.prospertec.diobank.teste

import com.prospertec.diobank.Cliente
import com.prospertec.diobank.enum.ClienteTipoEnum

fun main() {
    val c = Cliente(nome = "Jeff", cpf = "333.333.333-33", tipo = ClienteTipoEnum.PF, senha = "s1234")

    println(c)

    TesteAuth().autent(c)
}
