package com.example.santander_dev_week.ui

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import android.view.Menu
import android.view.MenuItem
import android.widget.TextView
import androidx.lifecycle.Observer
import androidx.lifecycle.ViewModelProvider
import com.example.santander_dev_week.R
import com.example.santander_dev_week.data.Conta


class MainActivity : AppCompatActivity() {

    private lateinit var mainViewModel: MainViewModel

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        setSupportActionBar(findViewById(R.id.toolbar))

        mainViewModel = ViewModelProvider(this).get(MainViewModel::class.java)
        buscarContaCliente()

        //throw RuntimeException("Test Crash")//Forçar Erro
    }

    private fun buscarContaCliente(){
        mainViewModel.buscarConta().observe(this, Observer { result ->
            findOnView(result)
        })
    }

    //Função de preenchimento dos dados do usuário
    private fun findOnView(conta: Conta){
        findViewById<TextView>(R.id.txtView_usuario).text = conta.cliente.nome
        findViewById<TextView>(R.id.txtView_agencia).text = conta.agencia
        findViewById<TextView>(R.id.txtView_conta).text = conta.numero
        findViewById<TextView>(R.id.txtView_saldo).text = conta.saldo
        findViewById<TextView>(R.id.txtView_valor_disponivel).text = conta.limite
        findViewById<TextView>(R.id.txt_view_num_cartao).text = conta.cartao.numeroCartao
    }

    override fun onCreateOptionsMenu(menu: Menu?): Boolean {
        val inflate = menuInflater
        inflate.inflate(R.menu.main_menu, menu)
        return true
    }

    override fun onOptionsItemSelected(item: MenuItem): Boolean {
        return when (item.itemId){
            R.id.idItem_01 -> {
                Log.d("CLICK", "Click em Notificações")
                true
            }
            else -> super.onOptionsItemSelected(item)
        }
    }


}