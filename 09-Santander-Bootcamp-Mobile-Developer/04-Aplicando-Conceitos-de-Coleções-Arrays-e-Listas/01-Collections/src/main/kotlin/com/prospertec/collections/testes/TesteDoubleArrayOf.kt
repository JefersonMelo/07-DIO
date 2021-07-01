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
    println(sals.filter { it > 3000.0 })

    println("----------------------")
    //contar quantidade do range de um dado valor
    println(sals.count { it in 1000.0..5000.0 })

     println("----------------------")
    //Filtro, busca por um valor específico
    println(sals.find { it == 4500.0 })



}