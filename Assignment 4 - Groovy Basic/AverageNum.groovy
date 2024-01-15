def calculateAverage() {
    print "How many integers do you want to input? "
    int counts
    try {
        count = System.in.newReader().readLine().toInteger()
    } catch (NumberFormatException e) {
        println "Error: Please enter a valid integer for the count."
        return
    }

    int sum = 0
    int number
    for (int i = 1; i <= count; i++) {
        print "Enter integer $i: "
        try {
            number = System.in.newReader().readLine().toInteger()
            sum += number
        } catch (NumberFormatException e) {
            println "Error: Please enter a valid integer for number $i."
            i-- // Decrement i to re-attempt the current number input
        }
    }

    float average = sum / (float) count
    println "The average is: $average"
}

calculateAverage()
