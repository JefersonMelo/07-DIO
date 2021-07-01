package com.prospertec.collections.repositorio

class Repositorio<T> {
    private val map = mutableMapOf<String, T>()

    fun create(id: String, v: T) {
        map[id] = v
    }

    fun findById(id: String) =  map[id]
}