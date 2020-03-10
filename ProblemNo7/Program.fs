open System

let IsPrime x =
    {2..x/2}
    |> Seq.exists (fun e -> x%e=0)
    |> not

let PrimeNumber nth:int32 =
    let PrimeSequence a =
       a
       |> Seq.unfold (fun e -> Some(e, e+1))
       |> Seq.filter IsPrime
       |> Seq.item (nth-1)

    2
    |> PrimeSequence

let NthPrimeNumber () =
    let t =
        Console.ReadLine()
        |> Convert.ToInt32

    for t in 1 .. t do
        let MaxNum =
            Console.ReadLine()
            |> Convert.ToInt32

        let nthPrime = PrimeNumber MaxNum
        printfn "%i" nthPrime

do NthPrimeNumber() |> ignore

