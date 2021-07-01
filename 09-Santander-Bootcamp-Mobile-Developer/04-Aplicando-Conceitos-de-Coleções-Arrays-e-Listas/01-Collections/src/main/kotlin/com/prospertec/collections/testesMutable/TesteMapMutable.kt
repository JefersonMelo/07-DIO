package com.prospertec.collections.testesMutable

import com.prospertec.collections.Funcionario
import com.prospertec.collections.repositorio.Repositorio

fun main() {
    val f1 = Funcionario(nome = "F1", salario = 4500.0, tipoContato = "PJ")
    val f2 = Funcionario(nome = "F2", salario = 3500.0, tipoContato = "PJ")
    val f3 = Funcionario(nome = "F3", salario = 2500.0, tipoContato = "CLT")
    val f4 = Funcionario(nome = "F4", salario = 1500.0, tipoContato = "CLT")

    val rep =  Repositorio<Funcionario>()

    rep.create(f1.nome, f1)
    rep.create(f2.nome, f2)
    rep.create(f3.nome, f3)
    rep.create(f4.nome, f4)

    println(rep.findById(f1.nome))
}