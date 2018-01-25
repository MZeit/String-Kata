open System
let Add (inputString: string) =
    inputString.Split([|","|], StringSplitOptions.RemoveEmptyEntries)
    |> Seq.map int
    |> Seq.sum
