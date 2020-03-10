open System
open System.Collections.Generic

let ParseStringToInt (value : string) : int32 =
    match (System.Int32.TryParse(value)) with
    | (true, value) -> value
    | (false, _) -> failwith "Invalid Input, Please input only integer digits"

let checkAndSplitStringUptoNthPart (stringValue : string) (input: int32) =
    let parts = stringValue.Split  [|'.'; ':' ; ' ' ; ','; ';'|]
    if parts.Length <> input then
        failwith "Not a Valid Input, Give maximum number of digits and number of consecutive digits"
    else
        parts

let MultiplyNumbersInString (subStr : String) : int32 =
    subStr
    |> Seq.fold (fun p c -> p * (int (ParseStringToInt(string c)))) 1

let LargestProduct () =
    try
        printfn "%s" "Please input the total number of digits and number of consecutive digits :"
        let stringValue = Console.ReadLine()
        let data = checkAndSplitStringUptoNthPart(stringValue)(2)
        let MaximumDigit = ParseStringToInt(data.[0])
        let ConsecutiveDigit = ParseStringToInt (data.[1])

        printfn "%s" "Please input the digits :"
        let Digits =
            Console.ReadLine()
            |> Convert.ToString

        let ProductsList = new List<int>()
        if Digits.Length = MaximumDigit then
            for i = 0 to Digits.Length - ConsecutiveDigit do
                let SubStr = Digits.Substring(i , ConsecutiveDigit)
                ProductsList.Add(MultiplyNumbersInString SubStr)

            if (ProductsList.Count > 0) then
                ProductsList
                |> Seq.max
                |> printfn "%i"
            else
                 failwith "The number of consecutive digits is not Found "
        else
            failwith "Given input is not equal to the number of digits"
    with
    | Failure(msg) -> printfn "%s" msg

do LargestProduct() |> ignore

