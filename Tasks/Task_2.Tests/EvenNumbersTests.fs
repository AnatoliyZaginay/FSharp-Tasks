module Task_2.Tests.EvenNumbersTests

open NUnit.Framework
open FsCheck
open FsUnit
open EvenNumbers

[<Test>]
let countEvenNumbersShouldBeEqualTest () =
    let countEvenNumbersFunctionsShouldBeEqual list =
        let countViaMapEqualToCountViaFilter = countEvenNumbersViaMap list = countEvenNumbersViaFilter list
        let countViaMapEqualToCountViaFold = countEvenNumbersViaMap list = countEvenNumbersViaFold list
        let countViaFilterEqualToCountViaFold = countEvenNumbersViaFilter list = countEvenNumbersViaFold list
        match countViaMapEqualToCountViaFilter, countViaMapEqualToCountViaFold, countViaFilterEqualToCountViaFold with
        | true, true, true -> true
        | _ -> false
    
    Check.QuickThrowOnFailure countEvenNumbersFunctionsShouldBeEqual

[<Test>]
let countEvenNumbersShouldWorkCorrectly () =
    countEvenNumbersViaMap [1; 2; 3; 4; 5] |> should equal 2
    countEvenNumbersViaMap [1; 2; -2; -3; 0; 3; 4; 5; 2] |> should equal 5
    countEvenNumbersViaMap [] |> should equal 0