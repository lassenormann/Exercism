module SumOfMultiples

let multiplesOf (numbers:int list) (devisor:int) = 
    numbers
    |> List.filter (fun n -> (n % devisor) = 0)

let sum (numbers: int list) (upperBound: int) = 
    let multipliesOfUptTo (n:int) =  multiplesOf [0..upperBound-1] n
    numbers
    |> List.collect multipliesOfUptTo
    |> List.distinct
    |> List.sum
    