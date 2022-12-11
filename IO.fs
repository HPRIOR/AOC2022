module AOC.IO

open System.IO

module Input =
    let inputSeq relativePath : string seq =
        let fullPath = Path.Combine(__SOURCE_DIRECTORY__, relativePath)
        File.ReadLines(fullPath)

    let withType (convert: 'a -> 'b) (inputSeq: 'a seq) : 'b seq = seq { for n in inputSeq -> convert n }
    
