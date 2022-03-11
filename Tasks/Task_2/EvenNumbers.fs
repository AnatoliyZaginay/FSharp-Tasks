module EvenNumbers

/// Counts the number of even numbers in the list using map.
let countEvenNumbersViaMap list =
    list |> List.map(fun x -> abs(x + 1) % 2) |> List.sum

/// Counts the number of even numbers in the list using filter.
let countEvenNumbersViaFilter list =
    list |> List.filter(fun x -> x % 2 = 0) |> List.length

/// Counts the number of even numbers in the list using fold.
let countEvenNumbersViaFold list =
    list |> List.fold(fun acc x -> acc + abs(x + 1) % 2) 0