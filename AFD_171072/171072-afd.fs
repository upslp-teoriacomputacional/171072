(*
 * *****************************************************************************
 *        Name:    Rodolfo Emanuel   
 *     Surname:    Vázquez Reyes
 *          ID:    171072
 *       Major:    IT Engineering
 * Institution:    Universidad Politécnica de San Luis Potosí
 *   Professor:    Juan Carlos González Ibarra
 * Description:    F# language program to perform a FDA.
 *                
 *  Written:       03/10/2020
 *  Last updated:  06/10/2020
 **************************************************************************** *)

//  These two libraries must be included. 
open System 
open System.Text.RegularExpressions
 (*------------------------------------------------------------------------------
 *  The System.Text.RegularExpressions library contains classes that provide
 *  access to the .NET regular expression engine. This library provides regular
 *  expression functionality that may be used from any platform or language
 *  that runs within .NET. In this case, F#.
 *  
 *  With this library, the RegexStringValidator function enables us to determine
 *  if a string belongs to a regular expression pattern.
 *------------------------------------------------------------------------------*)

//  Inital variables must be mutable with initial values, but they can be altered with the <- operator later on. 
let mutable symbol=""
let mutable fin=""
(*
*  -------------------------------------------------------------------------------------------
*  Functions must also be written before the main argument. Otherwise, the program will not work.
*)

// The first function will return an integer number. 
let caracter (character) : int = //     This function checks the string input and according to the automaton validator, returns a message.

    //  New values are assigned to the global mutable variables.
    symbol <- "" 
    fin <- ""
    //  New Local mutable variables are established to work only in this function.
    let mutable digit = "[0-9]"
    let mutable operators= "(\+|\-|\*|\/)"
    
    
    // We must compare if the input is a digit or a character
    if Regex.IsMatch(character, digit) then
        symbol <- "Digit\t"
        0 
    elif Regex.IsMatch(character, operators) then
        symbol <- "Operator"
        1 
    elif character.Equals(fin) then 
        2
    else 
        printfn "Unvalid Character " 
        4

let body() = //     This function prints the line of the table. This funcition is used in the head and table funcions. 
    printfn "+-----------------------+-----------------------+-----------------------+-----------------------+"
let head() = //     This function prints the title of each row. 
    printfn "|\tCurrent State\t|\tCharacter\t|\tSymbol   \t|\tNext State\t|"
    body()
let contenido (nextState, character, symbol,state) = //     This function receives variables & prints them. 
    printfn "|\t    %i    \t|\t    %c    \t|\t%s  \t|\t %i\t\t|" nextState character symbol state
    body()


[<EntryPoint>]
let main argv =
   // Since F# does not support charcacters in tables, numbers must be defined.

   //   Accepted State = 5 
   //   Error = 4 
   //   Transition States = 1,2,3 

   //  transition table from python [ [1,"E","E"],["E",2,"E"],[3,"E","E"],["E","E","A"]]
   let transitionT = [ [1; 4; 4] ; [4; 2; 4] ; [3; 4; 4] ; [4; 4; 5] ]
   
   let mutable state = 0
   printfn "\n\t\tF I N I T E\t\tD E T E R M I N I S T I C\tA U T O M A T O N" 
   printfn """
    +-------------------------------------+
    |    Input a string to evaluate:    |
    +-------------------------------------+"""
   let cadena = Console.ReadLine() //  This command stores keyboard input
   body() 
   head()
   let mutable charcaracter = 0 //  This variable must be defined so is used by the state table

   //   The for loop will iterate every element of the input. 
   for character in cadena do
    let mutable nextState = state
    charcaracter <- caracter(string character)
    // if the charcaracter is equal to 3, the transition table will appear. 
    if charcaracter < 4   then 
        state <- transitionT.[state].[charcaracter]
        if state = 4 then //    if the input is valid, the transition table will appear.
            printfn "|     %i      |  %c    |%s |     %i       |" nextState character symbol state
            body()
            
        contenido(nextState, character, symbol, state)
   if state <> 3 then //  if the input is unvalid, the transition table will warn the user. e
            printfn """|                                    Not valid String                    |
+-----------------------+-----------------------+-----------------------+-----------------------+"""
   if state = 3 && charcaracter < 4 then // When the for loop is finished, the transition table will show the end
            printfn "|\t    %i    \t|\t          \t|\tEnd of String\t|\t  \t \t|" state
            body()
            printfn """|                                    Valid String                                               |
+-----------------------+-----------------------+-----------------------+-----------------------+""" 
   0 // return an integer exit code