module ArithmeticParseTree

type ArithmeticParseTree =
| Leaf of int
| Tree of Operation * ArithmeticParseTree * ArithmeticParseTree
and Operation =
| Sum
| Subtraction
| Multiplication
| Division

let rec calculateArithmeticParseTree arithmeticParseTree =
    match arithmeticParseTree with
    | Leaf(value) -> value
    | Tree(operation, leftSubTree, rightSubTree) ->
        match operation with
        | Sum -> calculateArithmeticParseTree(leftSubTree) + calculateArithmeticParseTree(rightSubTree)
        | Subtraction -> calculateArithmeticParseTree(leftSubTree) - calculateArithmeticParseTree(rightSubTree)
        | Multiplication -> calculateArithmeticParseTree(leftSubTree) * calculateArithmeticParseTree(rightSubTree)
        | Division ->
            let divider = calculateArithmeticParseTree rightSubTree
            if divider = 0 then failwith "You can't divide by zero."
            calculateArithmeticParseTree(leftSubTree) / divider