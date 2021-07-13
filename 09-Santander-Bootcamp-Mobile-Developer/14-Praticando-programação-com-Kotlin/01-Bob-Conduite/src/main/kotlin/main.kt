
fun main() {

    var n = readLine()!!.toInt()

    while (n > 0) {
        var x = readLine()!!.split(' ')
        var result: Int = x[0].toInt() + x[1].toInt()
        println(result)
        n--
    }
}