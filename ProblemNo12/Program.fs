//Enter your code here. Read input from STDIN. Print output to STDOUT
open System
open System.Linq
open System.Collections.Generic

let GetPrimeFactor( triangleNumber : int32) : List<int> =
     let primeFactor = new List<int32> ()
     let mutable number:int32 = triangleNumber
     let mutable factor:int32 = 2

     while (number / factor <> 1) do
        if ((number % factor) = 0) then
             number <- number / factor
             primeFactor.Add(factor)
        else
             factor <- factor + 1

     primeFactor.Add(number)
     primeFactor

let main() =
    let testCaseNo =
        Console.ReadLine()
        |> Convert.ToInt32
    for testCaseNo in 1 .. testCaseNo do

    let mutable num = 1
    let noOfDivisor =
        Console.ReadLine()
        |> Convert.ToInt32
    let mutable countNoOfDivisor = 1

    while (countNoOfDivisor <= noOfDivisor) do
        countNoOfDivisor <- 1
        let triangleNumber = (num * (num + 1)) / 2
        if (triangleNumber > 1) then
            let primeFactor = GetPrimeFactor(triangleNumber)
            for i = 2 to primeFactor.Max() do
                let noOfPrimrFactor =
                    primeFactor
                    |> Seq.filter (fun x -> x = i)
                    |> Seq.length

                if (noOfPrimrFactor > 0) then
                    countNoOfDivisor <- countNoOfDivisor * (noOfPrimrFactor + 1)
        else
            countNoOfDivisor <- 1

        if countNoOfDivisor > noOfDivisor then
            printfn "%i " triangleNumber
        num <- num + 1

do main() |> ignore
