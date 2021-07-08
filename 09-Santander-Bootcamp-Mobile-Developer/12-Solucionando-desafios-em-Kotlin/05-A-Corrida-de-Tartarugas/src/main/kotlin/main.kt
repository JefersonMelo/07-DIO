import java.io.EOFException
import java.lang.Exception

fun main(args: Array<String>) {

    while (readLine().isNullOrEmpty()) {

        try {

            val l = readLine()?.toInt()
            val v = readLine()!!.split(" ").run { map { it.toInt() }}
            val orderAsc = v.toTypedArray()
            orderAsc.sort()
            when (orderAsc.last()) {
                in 0..9->{println(1)}
                in 10..19->{println(2)}
                else -> {println(3)}
            }

        } catch (f : EOFException ) {
            break
        } catch (n :EOFException ) {
            break
        } catch (e :Exception) {
            break
        }
    }
}
