module BinarySearchTree

open System

type Tree =
    | Empty
    | Node of value: int * leftNode: Tree * rightNode: Tree

let rec InsertDataIntoTree data (tree : Tree) =
    match tree with
    | Empty -> Node (data, Empty, Empty)
    | Node (value, leftNode, rightNode) when data <= value ->
        let leftNode = InsertDataIntoTree data leftNode
        Node (value, leftNode, rightNode)
    | Node (value, leftNode, rightNode) when data > value ->
        let rightNode = InsertDataIntoTree data rightNode
        Node (value, leftNode, rightNode)
    | _ -> tree

let PreOrderTraverser (tree : Tree) =
    let rec PreOrderTraverserRec (tree : Tree) =
        seq {
            match tree with
            | Empty -> ()
            | Node (value, leftNode, rightNode) ->
                yield value

                yield! PreOrderTraverserRec leftNode
                yield! PreOrderTraverserRec rightNode
        }
    PreOrderTraverserRec tree

let data = [ 5; 8;  3; 4; 7; 1; 6; 2 ]
let tree =
    data
    |> List.fold (fun n x -> n |> InsertDataIntoTree x) Empty
let dataAfterPreOrderTraverser =
    tree
    |> PreOrderTraverser
printfn "%A" tree
for data in dataAfterPreOrderTraverser do
 printfn "%d" data







