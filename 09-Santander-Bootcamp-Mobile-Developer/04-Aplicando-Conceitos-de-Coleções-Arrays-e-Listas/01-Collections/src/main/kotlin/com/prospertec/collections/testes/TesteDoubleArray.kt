package com.prospertec.collections.testes

fun main() {
    val sals = DoubleArray(3)

    sals[0] = 10000.0
    sals[1] = 3000.0
    sals[2] = 1500.0

    //Acessar e alterar o valor por indice, garantindo que o valor a ser alterado está contido na posição.
    sals.forEachIndexed { index, sal ->
        sals[index] = sal * 1.1
    }

    //Impressão do array
    sals.forEach { println("$it") }
}