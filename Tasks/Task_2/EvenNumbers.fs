module EvenNumbers

let CountEvenNumbersViaMap list =
    list |> List.map(fun x -> abs(x + 1) % 2) |> List.sum

let CountEvenNumbersViaFilter list =
    list |> List.filter(fun x -> x % 2 = 0) |> List.length

let CountEvenNumbersViaFold list =
    list |> List.fold(fun acc x -> acc + abs(x + 1) % 2) 0