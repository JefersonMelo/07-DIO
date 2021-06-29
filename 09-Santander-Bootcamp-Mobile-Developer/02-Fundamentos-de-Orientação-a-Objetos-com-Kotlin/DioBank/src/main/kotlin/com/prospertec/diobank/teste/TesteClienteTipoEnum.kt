package com.prospertec.diobank.teste

import com.prospertec.diobank.enum.ClienteTipoEnum

fun main() {
    ClienteTipoEnum.values().forEach { it->
        println(it)
    }
}