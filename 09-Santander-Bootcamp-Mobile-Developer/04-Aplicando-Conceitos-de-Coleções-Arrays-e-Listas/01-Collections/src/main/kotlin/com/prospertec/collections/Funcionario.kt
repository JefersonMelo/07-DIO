package com.prospertec.collections

data class Funcionario(
    val nome: String,
    val salario: Double,
    val tipoContato: String
){
    override fun toString(): String =
        """
            Nome: $nome
            Salário: $salario
            Tipo Contrato: $tipoContato
        """.trimIndent()
}