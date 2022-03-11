module Task_2.Tests.ArithmeticParseTreeTests

open System
open NUnit.Framework
open FsUnit
open ArithmeticParseTree

[<Test>]
let calculateArithmeticParseTreeShouldWorkCorrectly () =
    let firstTree = Tree(Sum, Tree(Subtraction, Leaf(7), Leaf(4)), Tree(Multiplication, Leaf(2), Leaf(4)))
    let secondTree = Tree(Division, Tree(Subtraction, Leaf(0), Leaf(10)), Leaf(5))
    let thirdTree = Tree(Multiplication, Tree(Sum, Leaf(7), Leaf(3)), Tree(Division, Leaf(1), Leaf(8)))
    let fourthTree = Tree(Sum, Tree(Subtraction, Leaf(1.5), Leaf(1.25)), Tree(Multiplication, Leaf(1.21), Leaf(2)))
    let fifthTree = Leaf(3)
    let incorrectTree = Tree(Division, Leaf(1), Leaf(0))

    calculateArithmeticParseTree firstTree |> should equal 11
    calculateArithmeticParseTree secondTree |> should equal -2
    calculateArithmeticParseTree thirdTree |> should equal 1.25
    calculateArithmeticParseTree fourthTree |> should equal 2.67
    calculateArithmeticParseTree fifthTree |> should equal 3
    (fun () -> calculateArithmeticParseTree incorrectTree |> ignore) |> should throw typeof<ArgumentException>