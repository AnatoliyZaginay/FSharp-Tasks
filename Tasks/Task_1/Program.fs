let factorial number =
    if number < 0 then failwith "Factorial can't be calculated for a negative number."
    let rec subFactorial currentNumber acc =
        if currentNumber = 0 then acc
        else subFactorial (currentNumber - 1) (acc * currentNumber)
    subFactorial number 1

let fibonacci number =
    if number < 0 then failwith "Element of Fibonacci sequence can't be calculated for a negative number."
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

let makeList n m =
    if m > n then failwith "m must be greater than n."
    let rec addElement list i =
        if i = m then list
        else addElement (list |> List.head |> fun x -> x * 2.0 :: list) (i + 1)
    reverseList (addElement [pown 2 n] n)

let findElement list element =
    let rec subFindElement list i =
        match list with
        | [] -> None
        | head :: tail ->
            if head = element then Some(i)
            else subFindElement tail (i + 1)
    subFindElement list 0