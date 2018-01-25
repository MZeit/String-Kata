open System
let Add (inputString: string) =
    inputString.Split([|",";"\n"|], StringSplitOptions.RemoveEmptyEntries)
    |> Seq.map int
    |> Seq.sum
