(*A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
a*a + b*b = c*c
For example, 3*3 + 4*4 = 9 + 16 = 25 = 5*5.
Given N , Check if there exists any Pythagorean triplet for which a+b+c = N
Find maximum possible value of abc among all such Pythagorean triplets, If there is no such Pythagorean triplet print -1 .
2  -- No of test Cases
12 -- Sum of Pythagorean triplet (N)
4  -- Sum of Pythagorean triplet (N)
Answer : 60, -1
*)

open System

let IntegerParse (value : string) : int32 =
    match (System.Int32.TryParse(value)) with
    | (true, value) -> value
    | (false, _) -> failwith "Invalid Input, Please input only integer digits"

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
    printfn "%s" "Please input the number of test cases :"
    let t =
        Console.ReadLine()
        |> Convert.ToInt32
    try
        for t in 1 .. t do
            printfn "%s" "Please input the Pythagorean Sum :"
            let pythagoreanSum =
                Console.ReadLine()
                |> IntegerParse
            let result = MaxPythagoreanTripletProduct pythagoreanSum
            printfn "%i" result
    with
    | Failure (msg) -> printfn "%s" msg

do main() |> ignore

