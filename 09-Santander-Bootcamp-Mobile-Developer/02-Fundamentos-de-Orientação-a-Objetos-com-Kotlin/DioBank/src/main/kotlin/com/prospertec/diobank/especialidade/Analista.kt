package com.prospertec.diobank.especialidade

import com.prospertec.diobank.Funcionario

class Analista(nome: String, cpf: String, salario: Double) : Funcionario(nome, cpf, salario) {
    override fun calcularAuxilio(): Double = salario * 0.1
}