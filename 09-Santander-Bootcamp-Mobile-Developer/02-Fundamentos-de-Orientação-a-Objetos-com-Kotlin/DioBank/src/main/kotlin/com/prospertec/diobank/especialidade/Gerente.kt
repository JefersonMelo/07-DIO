package com.prospertec.diobank.especialidade

import com.prospertec.diobank.Funcionario
import com.prospertec.diobank.util.ILogin

class Gerente(
    nome: String,
    cpf: String,
    salario: Double,
    val senha: String
) : Funcionario(nome, cpf, salario), ILogin {
    override fun calcularAuxilio(): Double = salario * 0.15

    override fun login(): Boolean = "s123" == senha

}