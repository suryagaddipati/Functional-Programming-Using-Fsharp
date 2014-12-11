namespace Functional_Programming_Using_Fsharp
module Chapter1 =
 let g n = n + 4
 let h x y = System.Math.Sqrt(x * x + y * y)
 let g' = fun n -> n + 4
 let h' = fun x y -> System.Math.Sqrt(x * x + y * y)

 let rec f  = function
           |0  -> 0
           |n  -> n + f(n - 1)
