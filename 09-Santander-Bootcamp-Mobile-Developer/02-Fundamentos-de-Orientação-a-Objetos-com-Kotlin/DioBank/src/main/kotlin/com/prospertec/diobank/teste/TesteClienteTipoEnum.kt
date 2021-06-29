package com.prospertec.diobank.teste

import com.prospertec.diobank.enum.ClienteTipoEnum

fun main() {
    //Acesso iterando Enum
    ClienteTipoEnum.values().forEach { it->
        println("$it -> ${it.desc}")
    }

    val pf = ClienteTipoEnum.PF
    println("$pf: ${pf.desc}")
    val pj = ClienteTipoEnum.PJ
    println("$pj: ${pj.desc}")
}