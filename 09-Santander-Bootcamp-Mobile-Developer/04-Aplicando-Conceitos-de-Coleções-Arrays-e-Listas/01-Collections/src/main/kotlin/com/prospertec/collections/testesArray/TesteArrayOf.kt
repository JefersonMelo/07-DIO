package com.prospertec.collections.testesArray

fun main() {
    val nomes = arrayOf("Jef", "Jos", "Jon")

    nomes.sort()
    nomes.forEach { print("$it, ") }

}