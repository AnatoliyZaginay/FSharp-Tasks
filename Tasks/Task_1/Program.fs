let factorial number =
    if number < 0 then failwith "Factorial can't be calculated for a negative number"
    let rec subFactorial currentNumber acc =
        if currentNumber = 0 then acc
        else subFactorial (currentNumber - 1) (acc * currentNumber)
    subFactorial number 1

let fibonacci number =
    if number < 0 then failwith "Element of Fibonacci sequence can't be calculated for a negative number"
    let rec subFibonacci firstNumber secondNumber i =
        if i = number then secondNumber
        else subFibonacci secondNumber (firstNumber + secondNumber) (i + 1)
    if number = 0 then 0
    else subFibonacci 0 1 1

let reverseList list = 
    let rec subReverseList list reversedList =
        match list with
        | [] -> reversedList
        | head :: tail -> subReverseList tail (head :: reversedList)
    subReverseList list []