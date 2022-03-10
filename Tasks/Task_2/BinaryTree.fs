module BinaryTree

type BinaryTree<'a> =
| Tree of 'a * BinaryTree<'a> * BinaryTree<'a>
| Leaf of 'a

let rec mapBinaryTree func binaryTree =
    match binaryTree with
    | Leaf(value) -> Leaf(func value)
    | Tree(value, leftSubTree, rightSubTree) -> Tree(func value, mapBinaryTree func leftSubTree, mapBinaryTree func rightSubTree)