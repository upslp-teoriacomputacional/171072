(*
 * *****************************************************************************
 *        Name:    Rodolfo Emanuel   
 *     Surname:    Vázquez Reyes
 *          ID:    171072
 *       Major:    IT Engineering
 * Institution:    Universidad Politécnica de San Luis Potosí
 *   Professor:    Juan Carlos González Ibarra
 * Description:    F# language program to show if a string is a Palindrome
 *                
 *  Written:       02/11/2020
 *  Last updated:  02/11/2020
 **************************************************************************** *)
open System

let isPalindrome str = 
    let str = str |> Seq.filter ((<>) ' ') |> Seq.toList
    str = (str |> List.rev)

["abc ba"; "abcba"; "a"; "aaba"; ""] 
|> List.map (fun x -> x, isPal x)

[<EntryPoint>]
let main argv =
    printfn "Input a string"
    
    0 // return an integer exit code
