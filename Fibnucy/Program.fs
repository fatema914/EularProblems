open System

let MaxPythagoreanTripletProduct (sumValue : int32) =
    let PythagoreanProduct =
        seq {
            for firstNo = 1 to sumValue / 3  do
                let SecondNo = (sumValue * sumValue - 2 * sumValue * firstNo) / (2 * sumValue - 2 * firstNo)
                let ThirdNo = sumValue - firstNo - SecondNo
                if ((firstNo * firstNo + SecondNo * SecondNo) = ThirdNo * ThirdNo) then
                    yield firstNo * SecondNo * ThirdNo
            }
    if Seq.isEmpty PythagoreanProduct then
        -1
    else
        PythagoreanProduct
        |>Seq.max

let main () =
    let t =
        Console.ReadLine()
        |> Convert.ToInt32

    for t in 1 .. t do
        let pythagoreanSum =
            Console.ReadLine()
            |> Convert.ToInt32

        let result = MaxPythagoreanTripletProduct pythagoreanSum
        printfn "%i" result

do main() |> ignore

