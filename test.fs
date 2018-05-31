// comments are cool

(* comments
are cool. *)

let myInt = 5
let myFloat = 3.14
let myString = "Hello, World!"

// Lists
let twoToFive = [2; 3; 4; 5]
let oneToFive = 1 :: twoToFive
let zeroToFive = [0;1] @ twoToFive

let square x = x * x
printfn "%A" (square 3)

let add x y = x + y
printfn "%A" (add 2 3)


let evens list =
    let isEven x = x % 2 = 0
    List.filter isEven list

printfn "%A" (evens oneToFive)


let sumOfSquaresTo100 =
    List.sum (List.map square [1..100])

printfn "%A" sumOfSquaresTo100


let sumOfSquaresTo100piped = 
    [1..100] |> List.map square |> List.sum

printfn "%A" sumOfSquaresTo100piped


let sumOfSquaresTo100withFun =
    [1..100] |> List.map (fun x -> x * x) |> List.sum

printfn "%A" sumOfSquaresTo100withFun


let sumOfSquaresto100verbose =
    let square n = n * n
    let oneTo100 = [1..100]
    let squares = List.map square oneTo100
    let sum = List.sum squares
    sum

printfn "%A" sumOfSquaresto100verbose


// Pattern matching
let x = "a"

match x with
    | "a" -> printfn "x is a"
    | "b" -> printfn "x is b"
    | _   -> printfn "x is something else"


let validValue = Some 99
let invalidValue = None
printfn "%A" validValue
printfn "%A" invalidValue

let optionPatternMatch input =
    match input with
        | Some i -> printfn "input is an int=%d" i
        | None   -> printfn "input is missing"

optionPatternMatch validValue
optionPatternMatch invalidValue

// Tuples
let twoTuple = (1, true)
let triple = ("a", 2, true)

// Records
type Person = { First:string; Last:string }
let bob = { First="Bob"; Last="Walthers" }
printfn "%A" bob

// Unions
type Temp =
    | DegreesC of float
    | DegreesF of float

let tempF = DegreesF 98.6
let tempC = DegreesC 0.0
printfn "%A" tempF
printfn "%A" tempC



