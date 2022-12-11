module AOC.Two

open AOC

module Solution =
    let answer =
        One.Solution.groupSums |> List.sortDescending |> List.take 3 |> List.sum
