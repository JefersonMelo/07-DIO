package com.prospertec.diobank.teste

import com.prospertec.diobank.Funcionario
import java.math.BigDecimal

fun main() {
    val f = Funcionario(nome = "Funcionário", cpf = "111.111.111.-11", salario = BigDecimal.valueOf(15000.0))

    println("Nome: ${f.nome}\n CPF: ${f.cpf}\n Salário: ${f.salario}")
}