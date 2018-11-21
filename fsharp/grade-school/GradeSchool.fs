module GradeSchool

type Student = string
type Grade = int
type School = Map<Grade, Student list>

let empty: School = Map.empty

let add (student: Student) (grade: Grade) (school: School): School = 
    match school.TryFind grade with
        | Some students -> 
            school 
            |> Map.remove grade 
            |> Map.add grade (student::students)
        | None -> 
            school 
            |> Map.add grade [student]

let studentSorter = List.sort

let noStudents: Student list = List.empty

let roster' (school: School): Student list = 
    let rosterOf school = 
        school
        |> Map.toList
        |> List.sortBy (fun (grade,_) -> grade)
        |> List.map (fun (_, students) -> students |> studentSorter)
        |> List.reduce List.append
    match school.IsEmpty with
        | true -> noStudents
        | _ -> rosterOf school


let mapToSortedLists = 
    Map.toList
    >> List.sortBy (fun (key,_) -> key)
    >> List.map (fun (_, list) -> list |> List.sort)

let roster (school: School): Student list = 
    match school.IsEmpty with
        | false -> school |> mapToSortedLists |> List.reduce List.append
        | true  -> noStudents
        
let grade (number: Grade) (school: School): Student list = 
    match school.TryFind number with
    | Some students -> students |> studentSorter
    | None          -> noStudents
