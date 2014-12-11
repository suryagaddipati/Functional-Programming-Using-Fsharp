namespace Functional_Programming_Using_Fsharp
module Chapter1 =
 let g n = n + 4
 let h x y = System.Math.Sqrt(x * x + y * y)
 let g' = fun n -> n + 4
 let h' = fun x y -> System.Math.Sqrt(x * x + y * y)

 let rec f  = function
           |0  -> 0
           |n  -> n + f(n - 1)
 let rec F  = function
           |0  -> 0
           |1  -> 1
           |n  -> F(n-1) + F(n - 2)

 let rec sum  = function
           |(m,0) -> m
           |(m,n) -> m + n + sum(m, n-1)
