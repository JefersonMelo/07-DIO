package com.prospertec.collections

fun main() {
    //Pair: Recebe dois Tipos quaisquer, chave e valor e cria um objeto
    val pair: Pair<String, Double> = Pair("V1", 5000.0)
    val map1 = mapOf(pair)

    map1.forEach { (key, value) -> println("Chave: $key\nValor: $value") }

    println("-----------------------")
    //Sintaxe infix
    val map2 = mapOf(
        "V2" to 3000.0,
        "V3" to 7000.0
    )
    map2.forEach { (t, u) -> println("Chave: $t\nValor: $u") }
}