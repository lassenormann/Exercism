module ArmstrongNumbers

// let digits' n = 
//     let rec digi pos = 
//         if n < pos 
//         then []
//         else (n%(pos*10))/pos::digi (pos*10)
//     digi 1

// let numberOfDigits n =  n |> digits |> List.length

let digits number = 
    let rec digitsRec ds = function 
        | d when d < 10 -> d::ds
        | d -> digitsRec ((d%10)::ds) (d/10)
    digitsRec [] number

let isArmstrongNumber number = 
    let digits = digits number
    let numberOfDigits = digits |> List.length
    digits
    |> List.sumBy (fun d -> pown d numberOfDigits)
    |> (=) number