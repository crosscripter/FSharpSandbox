let add x y = x + y
let sub x y = x - y

let print3Numbers a b c =
	printfn "a: %i" a
	printfn "b: %i" b
	printfn "c: %i" c

print3Numbers 5 (add 10 7) (sub 20 8)

let sign num =
	if num > 0 then "positive"
	elif num < 0 then "negative"
	else "zero"

// returns type unit ()
let helloWorld = printfn "Hello, World!"

// val addAndMakeString : x:int -> y:int -> string
let addAndMakeString x y = (x + y).ToString()

(* Currying *)

// val add2Numbers : int -> int -> int
let add2Numbers x y = x + y

// val add5toNumber : int -> int
let add5toNumber = addTwoNumbers 5

// val z:int = 11
let z = add5ToNumber 6

let holdOn = add2Numbers 7
let okDone = holdOn 8

let sumOfDivisors n =
	let rec loop current max acc =
		if current > max then 
			acc
		else
			if n % current = 0 then
				loop (current + 1) max (acc + current)
			else
				loop (current + 1) max acc
	let start = 2
	let max = n / 2
	let minSum = 1 + n
	loop start max minSum

printfn "%d" (sumOfDivisors 10)


// val giveMeAThree : 'a -> int
let giveMeAThree x = 3

// val throwAwayFirstInput : 'a -> 'b -> 'b
let throwAwayFirstInput x y = y

throwAwayFirstInput 5 "value"
// val it:string = "value"

throwAwayFirstInput "throwAway" 10.0
// val it:float = 10.0

throwAwayFirstInput 5 30
// val it:int = 30

let add x y = x + y
let throwAwayFirstInput x y = y

let z = add 10 (throwAwayFirstInput "this is a string" 5)
// val it:int = 15

let z = add 10 (throwAwayFirstInput 5 "this is a string")
// Error: This expression has type string but is here used with type int:


(*
Pattern Matching

match expr with
	| pat1 -> result1
	| pat2 -> result2
	| pat3 when expr2 -> result3
	| _ -> defaultResult
*)

let rec fib n =
	match n with
	| 0 -> 0
	| 1 -> 1
	| _ -> fib (n - 1) + fib (n - 2)

fib 1
// val it:int = 1

fib 10
// val it:int = 55

// val greeting : string -> string
let greeting name =
	match name with
	| "Steve" | "Kristina" | "Matt" -> "Hello!"
	| "Carlos" | "Maria" -> "Hola!"
	| "Worf" -> "nuqneH!"
	| "Pierre" | "Monique" -> "Bonjour!"
	| _ -> "DOES NOT COMPUTE!"

greeting "Monique"
// val it:string = "Bonjour!"

greeting "Sakura"
// val it:string = "DOES NOT COMPUTE!"

(* Shorthand Matching with function Keyword *)

let getPrice = function
	| "banana" -> 0.79
	| "watermelon" -> 3.49
	| "tofu" -> 1.09
	| _ -> nan

getPrice "tofu"
// val it:float = 1.09

getPrice "apple"
// val it:float = nan

// val factorial : int -> int
let rec factorial = function
	| 0 | 1 -> 1
	| n -> n * factorial (n - 1)

// val sign : int -> int
let sign = function
	| 0 -> 0
	| x when x < 0 -> -1
	| x when x > 0 -> 1

sign -55
// val it:int = -1

sign 108
// val it:int = 1

sign 0
// val it:int = 0

let getCity zip =
	match zip with
	| 68528 -> "Lincoln, Nebraska"
	| 90210 -> "Beverly Hills, California"

// Warning: Incomplete pattern matches on this expression.
// For example, the value '0' will not be matched.

let apartmentPrices numberOfRooms =
	match numberOfRooms with
	| 1 -> 500.0
	| 2 -> 650.0
	| 3 -> 700.0
	| _ -> failWith "Only 1-2- and 3- bedrooms available."


let rec fact x =
	if x < 1 then 1
	else x * fact (x - 1)

(* OR:
let rec fact = function
	| n when n < 1 -> 1
	| n -> n * fact (n - 1) 
*)

let rec gcd x y =
	if y = 0 the x
	else gcd y (x % y)

gcd 259 111 
// val it:int = 37


// val count : int -> unit
let rec count n =
	if n = 1000000 then
		printfn "done"
	else
		if n % 1000 = 0 then
			printfn "n: %i" n

		count (n + 1)

// https://en.wikibooks.org/wiki/F_Sharp_Programming/Recursion
