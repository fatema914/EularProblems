open System
open System.Linq

let Multiplication() =
    let t =""
    let mutable a0 = 0
    let  t = Convert.ToInt32(Console.ReadLine())
    while a0 < t do
        let N =""
        let N = Convert.ToInt32(Console.ReadLine())
        let  oddNumbers = Enumerable.Range(1, N-1).Where(fun  enum -> enum % 3 = 0 || enum % 5 = 0)
        let  sum = oddNumbers.Sum()
        printfn "%d"  sum
        sum = 0;
        a0 <- a0 + 1

Multiplication()
Console.ReadKey()  |> ignore



