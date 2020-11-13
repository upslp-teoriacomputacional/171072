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

let isPalindrome (testString: string) =
    let trimString = testString.Replace(" ", ""); //  Removes spaces if it finds spaces.
    let array = trimString.ToCharArray()// Saves the string as an array to 'array' variable
    
    printfn "\nTrimmed String: %A \n" trimString  //  Shows how the program interprets the character
    let reverse = Array.rev array // Reverse will be used to show the array in reverse
    printfn "Array in reverse: %A\n" reverse  // Prints the array in reverse

    if array=reverse then  //   if  condition to perform a comparison between both variables 
        printf "\n\nThe string: %A is a palindrome!\n\n\n" testString  //  if true, shows a positive message
    else printf "\n\nThe string: %A is not a palindrome\n\n\n" testString // else, shows that the string was not a palindrome. 

[<EntryPoint>]
let main argv =
    printfn " ----------------- "
    printfn "| Input a string: |"
    printfn " ----------------- "
    let testString = System.Console.ReadLine() //  Reads user input 
    isPalindrome(testString) //  calls to the 'isPalindrome' Function
    
    0 // return an integer exit code