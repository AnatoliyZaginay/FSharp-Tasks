module BinaryTree

type BinaryTree<'a> =
| BinaryTree of 'a * BinaryTree<'a> * BinaryTree<'a>
| Leaf of 'a

let rec mapBinaryTree func binaryTree =
    match binaryTree with
    | Leaf(value) -> Leaf(func value)
    | BinaryTree(value, leftSubTree, rightSubTree) -> BinaryTree(func value, mapBinaryTree func leftSubTree, mapBinaryTree func rightSubTree)