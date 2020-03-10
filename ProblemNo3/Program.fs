open System
open System.Linq
open Microsoft.FSharp.Math;;

let PrimeFactor() =
    let mutable a0 = 0L
    let t = Convert.ToInt64(Console.ReadLine())
    while a0 < t do
        let mutable number:int64 = Convert.ToInt64(Console.ReadLine())
        let mutable factor:int64 = 2L
        while (factor <= int64(sqrt(float number))) do
            if ((number % factor) = 0L) then
                number <- number / factor;
            else
                 factor <- factor + 1L;
        printfn "%i" number
        a0 <- a0 + 1L

do PrimeFactor() |> ignore
