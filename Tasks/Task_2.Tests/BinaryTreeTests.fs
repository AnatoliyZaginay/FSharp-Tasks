module Task_2.Tests.BinaryTreeTests

open NUnit.Framework
open FsUnit
open BinaryTree

[<Test>]
let mapBinaryTreeShouldWorkCorrectly () =
    let firstBinaryTree = Tree(1, Tree(2, Leaf(3), Leaf(4)), Tree(5, Leaf(6), Leaf(7)))
    let secondBinaryTree = Tree(1, Tree(2, Leaf(3), Leaf(4)), Leaf(5))
    let thirdBinaryTree = Tree("a", Leaf("b"), Tree("c", Leaf("d"), Leaf("e")))
    let fourthBinaryTree = Tree(1, Leaf(2), Leaf(3))
    let fifthBinaryTree = Leaf(1)

    mapBinaryTree (fun x -> x * 2) firstBinaryTree |> should equal (Tree(2, Tree(4, Leaf(6), Leaf(8)), Tree(10, Leaf(12), Leaf(14))))
    mapBinaryTree (fun x -> x * x) secondBinaryTree |> should equal (Tree(1, Tree(4, Leaf(9), Leaf(16)), Leaf(25)))
    mapBinaryTree (fun x -> "test " + x) thirdBinaryTree |> should equal (Tree("test a", Leaf("test b"), Tree("test c", Leaf("test d"), Leaf("test e"))))
    mapBinaryTree (fun x -> x % 2) fourthBinaryTree |> should equal (Tree(1, Leaf(0), Leaf(1)))
    mapBinaryTree (fun x -> $"{x}") fifthBinaryTree |> should equal (Leaf("1"))