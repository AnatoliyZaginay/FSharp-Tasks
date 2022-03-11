module Task_2.Tests.PrimeNumbersTests

open NUnit.Framework
open FsUnit
open PrimeNumbers

[<Test>]
let getPrimeNumbersSeqShouldWorkCorrectly () =
    [ for i in 0 .. 10 -> Seq.item i getPrimeNumbersSeq ] |> should equal [2; 3; 5; 7; 11; 13; 17; 19; 23; 29; 31]
    getPrimeNumbersSeq |> Seq.contains 277 |> should be True
    getPrimeNumbersSeq |> Seq.contains 2777 |> should be True