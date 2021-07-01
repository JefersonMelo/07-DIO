package com.prospertec.collections.testesArray

fun main() {
    //Array
    val arr = IntArray(5)
    var cont: Int = 0

    //Preenchimento dinâmico
    for (index in arr.indices) {
        arr[index] = cont++
    }

    //1ª Forma de iterar
    print("1ª: ")
    for (n in arr) {
        print("$n ")
    }
    println()

    //2ª Forma de iterar
    print("2ª: ")
    arr.forEach {
        print("$it ")
    }
    println()

    //3ª Forma de iterar
    print("3ª: ")
    for (i in arr.indices) {
        print("""${arr[i]} """)
    }
    println()

    //Reordenação
    arr.sortDescending()
    print("Reorder: ")
    arr.forEach {
        print("$it ")
    }

}