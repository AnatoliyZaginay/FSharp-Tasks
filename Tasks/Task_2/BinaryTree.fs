module BinaryTree

/// Binary Tree type implementation.
type BinaryTree<'a> =
| Tree of 'a * BinaryTree<'a> * BinaryTree<'a>
| Leaf of 'a

/// Builds a new binary tree whose elements are the results of applying the given function to each of the elements of the binary tree.
let rec mapBinaryTree func binaryTree =
    match binaryTree with
    | Leaf(value) -> Leaf(func value)
    | Tree(value, leftSubTree, rightSubTree) -> Tree(func value, mapBinaryTree func leftSubTree, mapBinaryTree func rightSubTree)