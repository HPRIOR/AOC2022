module AOC.Three

module Hand =
    type Shape =
        private
        | Rock of int
        | Paper of int
        | Scissor of int


        member this.value =
            function
            | Rock a -> a
            | Paper a -> a
            | Scissor a -> a

    let construct =
        function
        | "A"
        | "X" -> Rock 1
        | "B"
        | "Y" -> Paper 2
        | "C"
        | "Z" -> Scissor 3
        | char -> failwith $"Cannot construct hand from {char}"

module Round =
    let evaluate (hands: Hand.Shape * Hand.Shape) :  int =
        failwith ""

