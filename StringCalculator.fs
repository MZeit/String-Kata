open System
let Add (inputString: string) =
    inputString.Split([|",";"\n"|], StringSplitOptions.RemoveEmptyEntries)
    |> Seq.map int
    |> Seq.sum

// 4. 
open System.Text.RegularExpressions
open System

let getStringWithNumbers (wholeString: string) = wholeString.Split([|'\n'|], StringSplitOptions.RemoveEmptyEntries).[1]

let splitAndSum (del: string []) (numbersToSum: string) = 
    try
        numbersToSum.Split(del, StringSplitOptions.RemoveEmptyEntries) 
        |> Seq.ofArray 
        |> Seq.map int 
        |> Seq.sum
     with
        | :? System.OverflowException as ex ->  printfn "The number entered is too big or too small.";0
        | :? System.FormatException as ex -> printfn "Invalid Input String Format."; 0 

let Add stringWithDelimiteter = 
    match stringWithDelimiteter with 
    | x when Regex("//.\n.*").Match(x).Success -> (splitAndSum [|stringWithDelimiteter.[2..2]|] (getStringWithNumbers x))
    | y when Regex("-?[0-9]*.*").Match(y).Success -> (splitAndSum [|",";"\n"|] y)
