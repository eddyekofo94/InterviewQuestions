import jdk.nashorn.internal.objects.NativeArray.indexOf

/*
 QUESTION: calculate the distance of the nearest city from the user, starting at 0

 INPUT: tip,955; crk,123; dub,548;"

 OUTPUT: 123, 425, 430
 */

fun cityDistance(input: String): String {
    var key: String?
    var value: Int?
//    val map: HashMap<String, Int> = hashMapOf(1 to "x", 2 to "y", -1 to "zz")
    val cityMap = HashMap<String?, Int?>()

//    val pattern = Regex("-?[a-z0-9]+")

//   val listCities  = pattern.findAll(input)
    val listCities = Regex(pattern = """-?[a-z0-9]+""").findAll(input)
    for ((index, item) in listCities.withIndex()) {
        if (index % 2 != 0) {
            value = item.value.toInt()
//       println(" value: $value")
        } else {
            key = item.value
//           print("key: $key")
        }
        // TODO: Add the cities to a map
        println(cityMap.put(
                key,
                value
        ))
    }
    return input
}

fun main(args: Array<String>) {
    val input = "tip,955; crk,123; dub,548; clr,345; pvl,905;"
    cityDistance(input)
}