package com.prospertec.collections.testes

fun main() {
    val nomes = Array(3) { "" }

    nomes[0] = "Jef"
    nomes[1] = "Jos"
    nomes[2] = "Jon"

    nomes.sort()
    nomes.forEach { print("$it, ") }
}