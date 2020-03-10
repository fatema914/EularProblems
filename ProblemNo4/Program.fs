open System

let StringReverse (pNum : string) =
    pNum
    |> Seq.toArray
    |> Array.rev
    |> System.String

let IsPalindrome n =
    let s = string n in s = StringReverse s

let LargestPalindrom () =
    let t =
        Console.ReadLine()
        |>Convert.ToInt32

    for t in 1 .. t do
    let MaxNum =
        Console.ReadLine()
        |>Convert.ToInt64

    let digit = 3
    let smallestNo = pown 10 (digit-1)
    let largestNo = (pown 10 digit)-1
    seq { for i =  smallestNo to largestNo do
              for j =  largestNo downto smallestNo do
                  let product:int64 = Convert.ToInt64(i * j)
                  if (product<MaxNum)   && IsPalindrome  product then yield product }
    |> Seq.max
    |> printfn "%d"

do LargestPalindrom() |> ignore
