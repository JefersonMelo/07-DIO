package com.example.santander_dev_week.ui

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import com.example.santander_dev_week.data.Conta
import com.example.santander_dev_week.data.local.FakeData

class MainViewModel : ViewModel(){

    private val mutableLiveData: MutableLiveData<Conta> = MutableLiveData()

    fun buscarConta(): LiveData<Conta>{
        mutableLiveData.value = FakeData().getLocalData()

        return mutableLiveData
    }
}