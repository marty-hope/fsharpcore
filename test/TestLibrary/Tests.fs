// Learn more about F# at http://fsharp.org

module Test

open Xunit
open Library
open System.Collections

[<Fact>]    
let ``Library converts "Banana" correctly``() =
    let expected = """I used to be Banana but now I'm "Banana"!"""
    let actual =  getJsonNetJson "Banana"
    Assert.Equal(expected, actual)

[<Fact>]
let ``Test double list values``() =
    let list = [1;2;3;4]
    let doubledList = doubleValuesInList list
    Assert.Equal(doubledList.[0], 2)

[<Fact>]
let ``Test filter even numbers``() =
    let list = [1;2;3;4;5;6;7;8;9]
    let evenList = getEvenNumbers list
    Assert.Equal(evenList.[0], 2)
    Assert.Equal(evenList.[3], 8)
