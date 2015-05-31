//For all natural numbers n below 1000,
//list all the multiples of 3 and 5.

// Types we want to define first
// i.e. does it take an argument?



let filter(n:seq<int>):seq<int> =
    seq { for i in n do 
            if i % 3 = 0 || i % 5 = 0 then
                yield i}

let sum(n:seq<int>):int =
    Seq.sum(n)



[<EntryPoint>]
let main argv =
    printfn "%A" (filter [1..9])
    printfn "Sum of the sequence: %d" (filter [1..9] |> sum)
    printfn "%A" (filter [1..999]) 
    printfn "Sum of the sequence: %d" (filter [1..999] |> sum)
    0 // return an integer exit code

