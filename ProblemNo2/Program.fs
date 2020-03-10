open System
open Microsoft.FSharp.Collections

let Fibonacci() =
    let mutable a0 = 0
    let  t = Convert.ToInt32(Console.ReadLine())

    while a0 < t do
     let  maxValue = Convert.ToInt32(Console.ReadLine())
     let fib =
         (0, 1)
         |> Seq.unfold (fun state ->
             if (fst state + snd state > maxValue) then
                 None
             else
                 Some(fst state + snd state, (snd state, fst state + snd state)))

     let sum = Seq.sum (Seq.where (fun b -> (b%2 = 0)) fib)
     printfn "%A" sum
     a0 <- a0 + 1

Fibonacci()
Console.ReadKey()  |> ignore