package com.prospertec.collections.testesLists

import com.prospertec.collections.Funcionario

fun main() {
    val f1 = Funcionario(nome = "F1", salario = 4500.0, tipoContato = "PJ")
    val f2 = Funcionario(nome = "F2", salario = 3500.0, tipoContato = "PJ")
    val f3 = Funcionario(nome = "F3", salario = 2500.0, tipoContato = "CLT")
    val f4 = Funcionario(nome = "F4", salario = 1500.0, tipoContato = "CLT")
    val f5 = Funcionario(nome = "F5", salario = 5500.0, tipoContato = "CLT")
    val f6 = Funcionario(nome = "F6", salario = 7500.0, tipoContato = "PJ")

    val fs = setOf(f1, f2)
    val fs1 = setOf(f3, f4)
    val fs2 = setOf(f5, f6)

    //Unir listas em uma e imprimir, union ou vários union
    val unir = fs.union(fs1.union(fs2))
    unir.forEach { println(it) }

    println("-----------------------")
    //Subtração de uma lista para outra
    val fs3 = setOf(f1, f3, f5)
    val sub = fs3.subtract(fs)
    sub.forEach { println(it) }

    println("-----------------------")
    //Retorna o que há em comum entre às listas
    val int = fs3.intersect(fs2)
    int.forEach { println(it) }

}