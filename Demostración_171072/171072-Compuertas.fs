(* *****************************************************************************
 *        Name:    Rodolfo Emanuel   
 *     Surname:    Vázquez Reyes
 *          ID:    171072
 *       Major:    IT Engineering
 * Institution:    Universidad Politécnica de San Luis Potosí
 *   Professor:    Juan Carlos González Ibarra
 * Description:    F# language program to perform different set operations.
 *                
 *  Written:       21/09/2020
 *  Last updated:  21/09/2020
 * ************************************************************************** *)


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