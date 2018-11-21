module Accumulate

// Cheating using build-in list function
let accumulate' func input = input |> List.map func

// Not tail recursive. Because expressions called is NOT the recursive call. 
// func x must be placed
let rec accumulate'' func input = 
        match input with
        | [] -> []
        | x::xs -> func x::accumulate'' func xs

//Using computational expressions
let rec accumulate func input = 
    [for n in input -> func n]