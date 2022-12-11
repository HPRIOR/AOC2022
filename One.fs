module AOC.One

open AOC.IO

let private input = Input.inputSeq "inputs/one.txt"

module Solution =
    let private maybeStrToInt str =
        try
            str |> int |> Some
        with
        | :? System.FormatException -> None

    let groupSums =
        input
        |> Input.withType maybeStrToInt
        |> Seq.fold
            (fun (head :: tail) group ->
                match group with
                | Some i -> head + i :: tail // add i to current group
                | None -> 0 :: head :: tail) // reset count and prepend new group
            [ 0 ]

    let answer = groupSums |> List.max
