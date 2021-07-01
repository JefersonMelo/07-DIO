package com.prospertec.collections.testesMutable

import com.prospertec.collections.Funcionario

fun main() {
    val f1 = Funcionario(nome = "F1", salario = 4500.0, tipoContato = "PJ")
    val f2 = Funcionario(nome = "F2", salario = 3500.0, tipoContato = "PJ")
    val f3 = Funcionario(nome = "F3", salario = 2500.0, tipoContato = "CLT")
    val f4 = Funcionario(nome = "F4", salario = 1500.0, tipoContato = "CLT")

    val fs = mutableListOf(f1, f2)
    fs.forEach { println(it) }

    //Método adicionar
    println("-----------------")
    fs.add(f3)
    fs.forEach { println(it) }

    //Método remover
    println("-----------------")
    fs.remove(f1)
    fs.forEach { println(it) }

}