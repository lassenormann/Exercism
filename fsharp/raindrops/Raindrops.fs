module Raindrops
let drops = [(3,"Pling");(5,"Plang");(7,"Plong")]

let dropName' number (factor, name)  =  if number % factor = 0 then name else ""

let dropName number drop =
    match drop with
    | (factor, name) when number % factor = 0 -> name
    | _ -> ""

let convert' number = 
    drops
    |> List.fold (fun acc (n, s) ->  if number % n = 0 then acc+s else acc) ""
    |> function "" -> (string number) | s -> s

let convert number = 
    drops
    |> List.map (dropName number) 
    |> List.reduce (+)
    |> function "" -> (string number) | s -> s
