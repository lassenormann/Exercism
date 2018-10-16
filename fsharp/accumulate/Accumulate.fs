module Accumulate

let accumulate' func input = input |> List.map func

let rec accumulate func input = 
        match input with
        | [] -> []
        | x::xs -> func x::accumulate func xs