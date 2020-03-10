open System

let IsPrime (num : int64) =
    {2L .. int64(Math.Sqrt(float(num)))}
    |> Seq.exists (fun e -> num%e = 0L)
    |> not

let PrimeNumberSum () =
    let mutable sum : int64= 0L;
    let t =
        Console.ReadLine()
        |> Convert.ToInt32

    for t in 1 .. t do
        let MaximumNum =
            Console.ReadLine()
            |>Convert.ToInt64

        seq {
            for x in 2L..MaximumNum do
                if (IsPrime(x)) then
                    yield x
            }
        |> Seq.sum
        |> printfn "%A"

do PrimeNumberSum() |> ignore

