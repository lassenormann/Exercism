module CollatzConjecture

let rec collatz n acc = 
    match n with
        | 1 -> acc
        | n when (n % 2 = 0) -> collatz (n/2) (acc+1)
        | n -> collatz (3*n+1) (acc+1)

let steps number =
    match number with
        | n when n <= 0 -> None
        | n -> Some (collatz n 0)