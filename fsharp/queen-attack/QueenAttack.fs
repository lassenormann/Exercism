module QueenAttack

type Position = int * int
let create (pos: Position) =  
    match pos with 
        | (r, _) when not (r>=0 && r<=7) -> false
        | (_, c) when not (c>=0 && c<=7) -> false
        | _ -> true

let sameRow (r1,_) (r2, _) = r1=r2

let sameColumn (_,c1) (_, c2) = c1=c2

let diagonal (r1,c1) (r2, c2) = abs (r1-r2) = abs (c1-c2)
    
let canAttack' queen1 queen2 = 
    match queen1, queen2 with
        | q1, q2 when sameRow q1 q2 -> true
        | q1, q2 when sameColumn q1 q2 -> true
        | q1, q2 when diagonal q1 q2 -> true
        | _ -> false

let canAttack (r1, c1) (r2, c2) = 
    r1=r2 || c1=c2 || abs (r1-r2) = abs (c1-c2)
