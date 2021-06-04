package com.example.santander_dev_week.data.local

import com.example.santander_dev_week.data.Cartao
import com.example.santander_dev_week.data.Cliente
import com.example.santander_dev_week.data.Conta

class FakeData{
    fun getLocalData():Conta{
        val cliente = Cliente(nome = "Jeferson Melo")
        val cartao = Cartao(numeroCartao = "000000000000")

        return Conta(
          numero = "000000-1",
          agencia = "0000-1",
          saldo = "25.000,00",
          limite = "10.000,00",
          cliente,
          cartao
        );
    }
}
