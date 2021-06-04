package com.example.santander_dev_week.data

data class Conta(
    val numero: String,
    val agencia: String,
    val saldo: String,
    val limite: String,
    val cliente: Cliente,
    val cartao: Cartao
)
