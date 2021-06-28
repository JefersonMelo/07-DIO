import java.text.DecimalFormat

fun main(args: Array<String>) {

    do{
        print("Valor A: ")
        var a:Float = readLine()!!.toFloat()
        print("Valor B: ")
        var b:Float = readLine()!!.toFloat()


        println("Escolha Uma Operação: + - * / % ou S para sair")
        print("Opção: ")
        var op:String = readLine().toString().uppercase()

        if (op!="S"){
            print(resultado(op, a, b))
        }

    }while (op != "S")

    println("***** Fim *****")

}

fun resultado(op:String, a: Float, b: Float):String{
    val dec = DecimalFormat("###")
    var r:Float = 0f

    if(op == "+"){
        r = soma(a, b)
    }

    if(op == "-"){
        r = subtracao(a, b)
    }
    if(op == "*"){
        r = multiplicacao(a, b)
    }
    if(op == "/"){
        r = divisao(a, b)
    }
    if(op == "%"){
        r = restoDivisao(a, b)
    }
    return "Resultado: ${dec.format(r)}\n"
}

fun soma(a:Float, b:Float): Float{
    return a + b
}

fun subtracao(a:Float, b:Float): Float{
    return a - b
}

fun multiplicacao(a:Float, b:Float): Float{
    return a * b
}

fun divisao(a:Float, b:Float): Float{
    return a / b
}

fun restoDivisao(a:Float, b:Float): Float{
    return a % b
}
