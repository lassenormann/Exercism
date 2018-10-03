module Leap

let (|EvenlyDivisableBy|_|) divisor value = if (value % divisor = 0 ) then Some EvenlyDivisableBy else None

let leapYear (year) = match year with
    | EvenlyDivisableBy 400 -> true
    | EvenlyDivisableBy 100 -> false
    | EvenlyDivisableBy 4 -> true
    | _ -> false
