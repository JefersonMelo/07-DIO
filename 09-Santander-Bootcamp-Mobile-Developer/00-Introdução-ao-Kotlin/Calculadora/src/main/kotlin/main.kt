import java.text.DecimalFormat

fun main() {

    do {
        print("Valor A: ")
        val a: Float = readLine()!!.toFloat()

        println("Escolha Uma Operação: + - * / % ou S para sair")
        print("Opção: ")
        val op: String = readLine().toString().uppercase()

        print("Valor B: ")
        val b: Float = readLine()!!.toFloat()

        if (op != "S") {
            print(resultado(op, a, b))
            print("Continuar S ou N: ")
            val c: String = readLine().toString().uppercase()
            if (c == "N") break
        }

    } while (op != "S")

    println("***** Fim *****")

}

fun resultado(op: String, a: Float, b: Float): String {
    val dec = DecimalFormat("##.##")
    var r = 0f

    when (op) {
        "+" -> { r = soma(a, b) }
        "-" -> { r = subtracao(a, b) }
        "*" -> { r = multiplicacao(a, b) }
        "/" -> { r = divisao(a, b) }
        "%" -> { r = restoDivisao(a, b) }
    }
    return "Resultado: ${dec.format(r)}\n"
}

fun soma(a: Float, b: Float): Float {
    return a + b
}

fun subtracao(a: Float, b: Float): Float {
    return a - b
}

fun multiplicacao(a: Float, b: Float): Float {
    return a * b
}

fun divisao(a: Float, b: Float): Float {
    return a / b
}

fun restoDivisao(a: Float, b: Float): Float {
    return a % b
}
