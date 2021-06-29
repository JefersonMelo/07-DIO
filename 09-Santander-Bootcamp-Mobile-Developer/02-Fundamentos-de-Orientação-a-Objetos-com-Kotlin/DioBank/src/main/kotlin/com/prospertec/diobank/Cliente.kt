package com.prospertec.diobank

import com.prospertec.diobank.enum.ClienteTipoEnum
import com.prospertec.diobank.util.ILogin

class Cliente(
    nome: String,
    cpf: String,
    val tipo: ClienteTipoEnum,
    val senha: String
) : Pessoa(nome, cpf), ILogin {
    override fun login(): Boolean = "s1234" == senha

    override fun toString(): String = """
        Nome: $nome
        CPF: $cpf
        Tipo: ${tipo.desc}
    """.trimIndent()
}