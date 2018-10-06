module SpaceAge 

type Planet = 
    Earth
    | Mercury
    | Venus
    | Mars
    | Jupiter
    | Saturn
    | Uranus
    | Neptune

let secondsPerEarthYear = 31557600.0

let orbitalPeriodInEarthYears planet = 
    match planet with
    | Mercury -> 0.2408467
    | Venus -> 0.61519726
    | Mars -> 1.8808158
    | Jupiter -> 11.862615
    | Saturn -> 29.447498
    | Uranus -> 84.016846
    | Neptune -> 164.79132
    | _ -> 1.0

let age' (planet: Planet) (seconds: int64): float = 
    let orbitalPeriodSeconds = orbitalPeriodInEarthYears planet * secondsPerEarthYear
    (float seconds) / orbitalPeriodSeconds
    
let age planet (seconds:int64) = 
    planet
    |> orbitalPeriodInEarthYears
    |> (*) secondsPerEarthYear
    |> (/) (float seconds)    
