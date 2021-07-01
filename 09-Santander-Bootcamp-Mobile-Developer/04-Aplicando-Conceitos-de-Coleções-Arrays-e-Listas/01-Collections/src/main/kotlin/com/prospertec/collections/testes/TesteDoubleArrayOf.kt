package com.prospertec.collections.testes

fun main() {
    val sals = doubleArrayOf(10000.0, 3000.0, 1500.0)

    //Acessar e alterar o valor por indice, garantindo que o valor a ser alterado está contido na posição.
    sals.forEachIndexed { index, sal ->
        sals[index] = sal * 1.5
    }

    //Impressão do array ordenado
    sals.sort()
    sals.forEach { println("$it") }

    println("----------------------")
    println("Min: ${sals.minOrNull()}")
    println("Max: ${sals.maxOrNull()}")
    println("Med: ${sals.average()}")

    println("----------------------")
    val salMaiorQue3k = sals.filter { it > 3000.0 }
    println(salMaiorQue3k)
}