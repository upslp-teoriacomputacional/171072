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
 *  Last updated:  04/11/2020
 **************************************************************************** *)
 
open System
//  Nice try 

/// No me copies, por favor (-:
let isPalindrome (testString: string) =
    let array = testString.ToCharArray() // Saves the string as an array to 'array' variable
    let size = testString.Length //  Saves the length of the input to 'size' variable
    printfn "Normal Array : %A" array  //  Shows how the program interprets the character
    let reverse = Array.rev array // Reverse will be used to show the array in reverse
    printfn "Reverse Array: %A" reverse  // Prints the array in reverse

    if array=reverse then
        printf "The string %A is a palindrome!" testString
    else printf "The string %A is not a palindrome" testString 
  
   (*
let isPalindrome str = 
    let str = str |> Seq.filter ((<>) ' ') |> Seq.toList
    str = (str |> List.rev)
*)

[<EntryPoint>]
let main argv =
    printfn "Input a string without spaces: "
    let testString = System.Console.ReadLine() //  Reads user input 
    isPalindrome(testString) //  calls to the 'isPalindrome Function'

    0 // return an integer exit code