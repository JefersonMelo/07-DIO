package com.prospertec.collections.testesLists

import com.prospertec.collections.Funcionario

fun main() {
    val f1 = Funcionario(nome = "F1", salario = 4500.0, tipoContato = "PJ")
    val f2 = Funcionario(nome = "F2", salario = 3500.0, tipoContato = "PJ")
    val f3 = Funcionario(nome = "F3", salario = 2500.0, tipoContato = "CLT")
    val f4 = Funcionario(nome = "F4", salario = 1500.0, tipoContato = "CLT")

    val fs = listOf(f1, f2, f3, f4)

    fs.forEach { println(it) }

    println("---------------------")
    // Busca especializada, se repetido vai buscae a primeira instância
    println(fs.find { it.nome == "F2"})

    println("---------------------")
    //imprimir ordenado por
    fs.sortedBy { it.salario }.forEach { println(it) }

    println("---------------------")
    //imprimir agrupado por
    fs.groupBy { it.tipoContato }.forEach { println(it) }

}
