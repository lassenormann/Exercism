module ArmstrongNumbers

let digits n = 
    let rec digi pos = 
        if n < pos 
        then []
        else (n%(pos*10))/pos::digi (pos*10)
    digi 1

let numberOfDigits n =  n |> digits |> List.length

let isArmstrongNumber number = 
    let numberOfDigits = numberOfDigits number
    number
    |> digits
    |> List.sumBy (fun n -> pown n numberOfDigits)
    |> (=)  number