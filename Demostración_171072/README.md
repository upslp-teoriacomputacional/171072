## F# Program about Logical Operators

 *        Name:    Rodolfo Emanuel Vázquez Reyes
 *          ID:    171072
 *       Major:    IT Engineering
 * Institution:    Universidad Politécnica de San Luis Potosí
 *   Professor:    Juan Carlos González Ibarra
 * Description:    F# language program to perform different set operations.
 *                
 *  Written:       21/09/2020


This was my second F# program directly translated from Python. 
The purpose of this program was to illustrate different Boolean Operators such as AND, OR, NOR, XOR.

In order for the translation to be made, concepts and topics regarding Boolean Operators in F# must be understood. 
The most complex for me to implement was the XOR Diffrence, because since there is no direct reserved function in F#,
the use of the symbols <> had to be used. This does the same as XOR.
I learned this from a programming forum.

The easiest were: AND, OR, because F# already includes functions for those operations. 

For running this program I used .NET tools.
I ran this program from a Git Bash console; the terminal must be opened in the location of the program and .Net must also
be installed on the system. The command "dotnet run" must be used for the program to be executed. 

##Solutions
I found an equivalent method for performing the XOR Operation in F# at <a href="https://stackoverflow.com/questions/7656054/how-to-do-boolean-exclusive-or" target="\_blank"> (Boolean XOR in F#).


## License
[MIT](https://choosealicense.com/licenses/mit/)

## Source Code

```F#

# - Program.fs *- coding: utf-8 -*-
open System

//  We start the program by creating a bool list. Later on, each truth table will iterate onto these elements.

let booleanos= [true; false]

[<EntryPoint>]
let main argv =
    printfn"\n   OR - TRUTH TABLE"  //  OR Truth Table
    printfn"  X\t  Y\tX or Y"
    for i in 1 .. 22 do     //  This for loop prints a separation line.
        if ( i = 22 ) then
            printf"-\n"
        else
        printf"-"
    for x in booleanos do   //  For loop must be used to go through the table.
        for y in booleanos do
        printfn"%b\t%b\t%b"x y (x||y)
    printfn""

    printfn"\n   AND - TRUTH TABLE"  //  AND Truth Table
    printfn"  X\t  Y\tX and Y"
    for i in 1 .. 23 do     //  This for loop prints a separation line.
        if ( i = 23 ) then
            printf"-\n"
        else
        printf"-"
    for x in booleanos do   //  For loop must be used to go through the table.
        for y in booleanos do
        printfn"%b\t%b\t%b"x y (x&&y)
    printfn""

    (*---------------------------------------------------------
     * The NOT operator produces an inverted version of the
     * input at its output. It is also known as an inverter.
     * If the input variable is A, the inverted output 
     * is known as NOT A.
     *---------------------------------------------------------*)

    printfn"\n   NOT - TRUTH TABLE"  //  NOT Truth Table
    printfn"  X\t  NOT X\t"
    for i in 1 .. 16 do     //  This for loop prints a separation line.
        if ( i = 16 ) then
            printf"-\n"
        else
        printf"-"
    for x in booleanos do //  For loop must be used to go through the table. It is not necessary to execute the same loop for Y.
        printfn"%b\t%b"x (not x)
    printfn""

    (*--------------------------------------------------------------------
     * The XOR logical operation, or exclusive or, takes two boolean
     * operands and returns true if and only if the operands are different.
     * Thus, it returns false if the two operands have the same value.
     * So, the XOR operator can be used, for example, when we have to
     * check for two conditions that can't be true at the same time.
     *--------------------------------------------------------------------*)    

    printfn"\n   XOR - TRUTH TABLE"  //  XOR Truth Table
    printfn"  X\t  Y\tX xor Y"
    for i in 1 .. 23 do     //  This for loop prints a separation line.
        if ( i = 23 ) then
            printf"-\n"
        else
        printf"-"
    for x in booleanos do   //  For loop must be used to go through the table.
        for y in booleanos do
        printfn"%b\t%b\t%b"x y (x<>y)
    printfn""
    0 //  return an integer exit code