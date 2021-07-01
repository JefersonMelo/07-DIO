package com.prospertec.collections.testeExtends

import com.prospertec.collections.functionsExtends.media
import com.prospertec.collections.functionsExtends.somatoria

fun main() {
    val sals = arrayOf(
        "2000".toBigDecimal(),
        "5000".toBigDecimal(),
        "7500".toBigDecimal()
    )
    println("Soma: ${sals.somatoria()}")

    println("-----------")
    println("Mádia: ${sals.media()}")
}