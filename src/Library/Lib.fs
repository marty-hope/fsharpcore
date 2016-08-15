// Learn more about F# at http://fsharp.org

module Library

open System
open Newtonsoft.Json

let getJsonNetJson value = 
    sprintf "I used to be %s but now I'm %s!" value  (JsonConvert.SerializeObject(value))


let doubleValuesInList list =
    List.map (fun x -> x * 2) list

let getEvenNumbers list =
    List.filter (fun x -> x % 2 = 0) list
