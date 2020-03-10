open System

let SumSquareDiff () =
    let t =
        Console.ReadLine()
        |>Convert.ToInt32

    for t in 1 .. t do
        let MaxNum=
          Console.ReadLine()
          |>Convert.ToInt64

        let squareSum:int64 = MaxNum * (MaxNum+1L) * (2L * MaxNum + 1L) / 6L
        let sumSquare:int64 = pown (MaxNum * (MaxNum + 1L) / 2L) 2
        let difference = sumSquare - squareSum
        printfn "%i" difference

do SumSquareDiff() |> ignore
