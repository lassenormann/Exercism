module Bob
 open System
 open System.Text.RegularExpressions

 let isQuestion (s:string) = s.Trim().EndsWith("?")

 let allLettersAreUpper (s:string) =
    Seq.toList s
    |> List.filter Char.IsLetter
    |> List.forall Char.IsUpper

 let hasLetters (s:string) =
    Seq.toList s
    |> List.exists Char.IsLetter

 let isYelling s = hasLetters s && allLettersAreUpper s

 let isSilence s = String.IsNullOrWhiteSpace s

 let sentences s = Regex.Split (s, "([.?])") |> Array.toList

 let anySentence s pred = 
    s 
    |> sentences 
    |> List.exists pred

 let anyIsYelling phrase = anySentence phrase isYelling 

 let response (input: string): string = 
    let res = (isSilence input, isQuestion input, isYelling input)
    match res  with
    | true, _, _        -> "Fine. Be that way!" //Silence
    | _, true, true     -> "Calm down, I know what I'm doing!" //Yelling question
    | _, true, _        -> "Sure." //Question
    | _, _, true        -> "Whoa, chill out!" //Yelling
    | _                 -> "Whatever." 


