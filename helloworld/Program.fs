// Learn more about F# at http://fsharp.org

open FSharp.Scanf

printfn "what is the ultimate answer?"

try
  let ans = scanfn "%i"
  if ans = 42 then
    printfn "correct."
  else
    printfn "%i? no." ans
  with
    | _ -> printfn "you entered something other than a number."
