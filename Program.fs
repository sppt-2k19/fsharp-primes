// Learn more about F# at http://fsharp.org

open System
open System.Collections

[<EntryPoint>]
let main argv =
    //Implementation taken from http://www.fssnip.net/7D/title/Prime-numbers-Sieve-of-Eratosthenes
    let primes max = 
        let array = new BitArray(max, true);
        let lastp = Math.Sqrt(float max) |> int
        for p in 2..lastp+1 do
            if array.Get(p) then
                for pm in p*2..p..max-1 do
                    array.Set(pm, false);
                    
        seq { for i in 2..max-1 do if array.Get(i) then yield i } |> Seq.last
        
    
    let result = primes 100
    printfn "%i" result
        
    0 // return an integer exit code
