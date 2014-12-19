namespace Functional_Programming_Using_Fsharp
module Chapter2 =
 let f n = (n%2 = 0 || n % 3 = 0) && n % 5 <> 0  

 let  pow(s: string, n) = 
  let rec pow1(final,n)= 
         match n with
          |1 -> final
          |_ -> pow1(s+final,n-1)
  pow1(s,n)

 let isIthChar (str: string, i, ch) = str.[i] = ch

 let occFromIth(str: string,i,ch)= 
  let rec occFromIth1(i,count)= 
            match i with
            | _ when i>=str.Length -> count
            | _ when isIthChar(str,i,ch) -> occFromIth1(i+1,count+1)
            | _ -> occFromIth1(i+1,count)
  occFromIth1(i,0)
           

                