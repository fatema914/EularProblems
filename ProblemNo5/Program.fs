open System

let Smallestmultiple () =
    let t =
        Console.ReadLine()
        |>Convert.ToInt32

    for t in 1 .. t do
    let mutable isDivisable =true
    let mutable isMultiply =true
    let mutable smallestMultiplier =1
    let mutable numCount =1

    let MaxNum =
        Console.ReadLine()
        |>Convert.ToInt32
    seq {  while (isDivisable = true ) do
                 while(numCount <= MaxNum && isMultiply = true) do
                      if (smallestMultiplier%numCount=0) then
                         if (numCount=MaxNum) then
                            yield smallestMultiplier
                            isDivisable<-false
                            isMultiply<-false
                         else
                         numCount<-numCount+1
                         isMultiply<-true
                      else
                      smallestMultiplier<-smallestMultiplier+1
                      numCount<-1
        }
    |> Seq.max
    |> printfn "%i"

do Smallestmultiple() |> ignore

