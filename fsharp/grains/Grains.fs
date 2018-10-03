module Grains

let rec squareValue n = 
    if n = 1 then 1UL
    else 2UL * squareValue (n-1)

let isValidSquareNumber n = 1 <=n && n <= 64

let square n =
    if isValidSquareNumber n  then squareValue n |> Ok
    else Error "Invalid input"

let total : Result<uint64, string> = 
    [1..64]
    |> List.map squareValue
    |> List.sum 
    |> Ok