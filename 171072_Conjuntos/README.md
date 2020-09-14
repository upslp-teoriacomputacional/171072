(*
 * *****************************************************************************
 *        Name:    Rodolfo Emanuel   
 *     Surname:    Vázquez Reyes
 *          ID:    171072
 *       Major:    IT Engineering
 * Institution:    Universidad Politécnica de San Luis Potosí
 *   Professor:    Juan Carlos González Ibarra
 * Description:    F# language program to perform different set operations.
 *                
 *  Written:       14/09/2020
 **************************************************************************** *)

This was my first F# program directly translated from Python. 
The purpose of this program was to illustrate different Set Operations such as union, intersection, difference and symmetric difference;
along with some functions used to perform Transformation, Addition and Removal of elements. 

In order for the translation to be made, concepts and topics regarding Sets in F# must be understood. 
The most complex for me to implement was the Symmetric Diffrence, because since there is no direct reserved function in F#,
a combination of two operations had to be combined. I learned this from a website that compared different Sets Operations in 
different Programming languages, including F#.

The easiest were: Union, Intersection and Difference, because F# already includes functions for those operations. 

For running this program I used .NET tools.
I ran this program from a Git Bash console; the terminal must be opened in the location of the program and .Net must also
be installed on the system. The command "dotnet run" must be used for the program to be executed. 

When analyzing the program, a question arised: Is the Quadratic Allocation Problem NP-complete or is it in P?
I understand that a Polynomial time & complexity depends on the size of the input. 

Either give a reduction to show it is NP-complete or give a polytime algorithm to solve it.

I also understand that it is different to verify than to solve in polynomial time. When looking for answers, concepts such as deterministic and 
non-deterministic Turing machines came to me. 
This Program is Deterministic, because the result must be the same everytime it is run. 
This was a confunsing question because I know that this can be quickly checked by observing different operations of Sets in the programs and sizes of 
the input (elements in a set) present in the code; but I don't know how to reduce/optimize the algorithm by being only assignations, declarations 
and equalizations present in different lines.