fun main(args: Array<String>) {

    val n = readLine()!!.toInt()
    //declare suas variaveis auxiliares e continue a solucao
    var sum = 0
    var numFib = 1

    print("0")
    for (i in 1..(n-1)) {

        print(" $numFib")
        numFib += sum
        sum = numFib - sum

    }
    println()
}