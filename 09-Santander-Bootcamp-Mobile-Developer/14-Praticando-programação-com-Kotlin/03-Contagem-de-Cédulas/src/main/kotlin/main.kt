import java.util.Scanner

fun main(args: Array<String>) {
    val input = Scanner(System.`in`)

    var valor = input.nextInt()
    println(valor)

    val cedulas = arrayOf(100, 50, 20, 10, 5, 2, 1)

    for (nota in cedulas){
        var qtdCedulas = valor / nota
        println("${qtdCedulas} nota(s) de R$ ${nota},00");
        valor %= nota
    }
}  