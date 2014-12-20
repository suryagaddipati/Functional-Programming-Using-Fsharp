namespace Functional_Programming_Using_Fsharp
module Chapter2 =
 let f n = (n%2 = 0 || n % 3 = 0) && n % 5 <> 0  

 let rec pow(s: string, n) = 
     match n with
          |1 -> s
          |_ -> s + pow(s,n-1)

 let isIthChar (str: string, i, ch) = str.[i] = ch

 let rec occFromIth(str: string,i,ch)= 
     match i with
         | _ when i>=str.Length -> 0
         | _ when isIthChar(str,i,ch) -> 1 + occFromIth(str,i+1,ch)
         | _ -> occFromIth(str,i+1,ch)
                