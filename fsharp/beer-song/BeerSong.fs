module BeerSong

let reciteBottle = function
        | 0 -> ["No more bottles of beer on the wall, no more bottles of beer.";
                "Go to the store and buy some more, 99 bottles of beer on the wall."] 
        | 1 -> ["1 bottle of beer on the wall, 1 bottle of beer.";
                "Take it down and pass it around, no more bottles of beer on the wall."]
        | 2 -> ["2 bottles of beer on the wall, 2 bottles of beer.";
                "Take one down and pass it around, 1 bottle of beer on the wall."]
        | n -> [sprintf "%i bottles of beer on the wall, %i bottles of beer." n n;
                sprintf "Take one down and pass it around, %i bottles of beer on the wall." (n-1)]

let rec recite n = function
            | 1 -> reciteBottle n
            | t -> List.concat [(reciteBottle n);[""];(recite (n-1) (t-1))]
