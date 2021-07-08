import java.io.Console

fun main(args: Array<String>) {

    fun Double.format(digits: Int) = "%.${digits}f".format(this).replace(',', '.')

    val (a, b, c) = readLine()!!.split(" ").map { it.toDouble() }
    val result: Double

    //insira as variaveis de acordo com o calculo do perimetro e area

    // 2º
    if (a < (b + c) && b < (a + c) && c < (a + b))
    {
        result = a + b + c;
        println("Perimetro = ${result.format(1)}")
    }
    else
    {
        result = (a + b) * c / 2.0;
        println("Area = ${result.format(1)}")
    }

    /* 1ª
    val p = (a + b + c).format(1)

    val r = (((a + b) * c / 2)).format(1)

    if (a < (b + c) && b < (a + c) && c < (a + b)) println("Perimetro = $p")
    else println("Area = $r")
    */
}