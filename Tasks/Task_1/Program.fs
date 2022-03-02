let factorial number =
    if number < 0 then failwith "Factorial can't be calculated for a negative number"
    let rec subFactorial currentNumber acc =
        if currentNumber = 0 then acc
        else subFactorial (currentNumber - 1) (acc * currentNumber)
    subFactorial number 1