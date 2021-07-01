package com.prospertec.collections.testes

fun main() {
    val nomes = arrayOf("Jef", "Jos", "Jon")

    nomes.sort()
    nomes.forEach { print("$it, ") }

}