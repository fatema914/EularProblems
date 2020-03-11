(*Work out the first ten digits of the sum of N- 50 digitnumbers
Sample input
5
37107287533902102798797998220837590246510135740250
46376937677490009712648124896970078050417018260538
74324986199524741059474233309513058123726617309629
91942213363574161572522430563301811072406154908250
23067588207539346171171980310421047513778063246676
Sample Output
  -- 2728190129
*)
open System

let main () =
    let noOfInput =
           Console.ReadLine()
           |> Convert.ToInt32

    let digitSum=
        seq {
            for noOfInput in 1 .. noOfInput do
                let digits = Console.ReadLine()
                yield (bigint.Parse(digits))
            }
        |> Seq.sum

    printfn "%s" (Convert.ToString(digitSum)).[0..9]

do main () |> ignore
