package com.prospertec.collections.repositorio

class Repositorio<T> {
    private val map = mutableMapOf<String, T>()

    fun create(id: String, v: T) {
        map[id] = v
    }

    fun remove(id: String) = map.remove(id)

    fun findById(id: String) = map[id]

    fun findAll() = map.values

}