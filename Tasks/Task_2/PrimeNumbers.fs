module PrimeNumbers

let getPrimeNumbersSeq =
    let rec isPrime number primeNumbers =
        match primeNumbers with
        | [] -> true
        | head :: tail when float head > sqrt(float number) -> true
        | head :: tail when number % head <> 0 -> isPrime number tail
        | _ -> false
    
    let rec generatePrimeNumbers number primeNumbers =
        seq {
            if isPrime number (List.rev primeNumbers) then
                yield number
                yield! generatePrimeNumbers (number + 1) (number :: primeNumbers)
            else
                yield! generatePrimeNumbers (number + 1) primeNumbers
        }

    generatePrimeNumbers 2 []