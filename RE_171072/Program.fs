(*
 * *****************************************************************************
 *        Name:    Rodolfo Emanuel   
 *     Surname:    Vázquez Reyes
 *          ID:    171072
 *       Major:    IT Engineering
 * Institution:    Universidad Politécnica de San Luis Potosí
 *   Professor:    Juan Carlos González Ibarra
 * Description:    F# language program to show Regular Expressions
 *                
 *  Written:       22/10/2020
 *  Last updated:  23/10/2020
 **************************************************************************** *)

open System.Text.RegularExpressions  //  Regular expressions Library must be included for performing regex expressions. 
open System

//  A mutable variable has to be defined in order for values to change in the progam
let mutable tokens = []     //  For String tokens 

(*---------------------------------------------------------
 *  In programming, a token is a single element of a 
 *  programming language. There are five categories of
 *  tokens: 1) constants, 2) identifiers,
 *  3) operators, 4) separators, and 5) reserved words. 
 *  For example, the reserved words "new" and "function"
 *  are tokens of the JavaScript language.
 *---------------------------------------------------------*)


let sourceCode = "float absoluteMagnitude = 26;".Split(' ')  // A sample "source code" line is given. This will be evaluated

for word in sourceCode do  // A for loop is requiered for each character to be evaluated. 
    if List.exists ((=)word) ["float";"str"; "int"; "bool"] then //  This line checks for the data type
        tokens <- List.append tokens [word]
    elif Regex.IsMatch(word, "[A-Za-z]") then //  This line checks the name of the given variable
        tokens <- List.append tokens [word]
    elif List.exists ((=)word) ["*";"-";"/";"+";"%";"="] then //  This line checks for the operator 
        tokens <- List.append tokens [word]
    elif Regex.IsMatch (word,"[0-9]") then // This line checks for the value of the given varible. 
        if word.[word.Length - 1] = ';' then
            tokens <- List.append tokens [word.[0..(word.Length-2)]]
            tokens <- List.append tokens [";"]  // This line checks for the semicolon at the end of the line. 
        else
            tokens <- List.append tokens [word]
printfn "%A" tokens // This line prints each token found from an array. 
    

let variablePROLOG(w : byref<string>) : bool=  /// We must write another function that will check for the name of the variable. 
    if (Char.IsLetter(w.[0]) && Char.IsUpper(w.[0]) || w.[0] = '_') then //  This line checks if the first character is Uppercase or underlined . 
        w <- w.[1..(w.Length-1)] //  The first character is removed
        while (not (String.IsNullOrEmpty(w)) && (Char.IsNumber w.[0] || w.[0] = '_')) do //  A while loop condition is added until there are no more elements to be checked. If 
        // if there are still characters in w, if the first character is alphanumeric, it continues. 
            w <- w.[1..(w.Length-1)] // The first character is removed. 
    String.IsNullOrEmpty(w)  

[<EntryPoint>]
let main argv =
    printfn " LINE OF CODE: ^ "
    0 // return an integer exit code