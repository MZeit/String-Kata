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
    numbersToSum.Split(del, StringSplitOptions.RemoveEmptyEntries) 
    |> Seq.ofArray 
    |> Seq.map int 
    |> Seq.sum

let Add stringWithDelimiteter = 
    match stringWithDelimiteter with 
    | x when Regex("//.\n.*").Match(x).Success -> (splitAndSum [|stringWithDelimiteter.[2..2]|] (getStringWithNumbers x))
    | y when Regex("-?[0-9]*.*").Match(y).Success -> (splitAndSum [|",";"\n"|] y)
