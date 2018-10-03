module TwoFer

let twoFerFunctionSyntax = function 
    | Some name -> sprintf "One for %s, one for me." name 
    | None -> "One for you, one for me."

let twoFer person = match person with
    | Some name -> sprintf "One for %s, one for me." name
    | None -> "One for you, one for me."