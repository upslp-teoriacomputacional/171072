## F# Program about Set Operations


 *        Name:    Rodolfo Emanuel Vázquez Reyes
 *          ID:    171072
 *       Major:    IT Engineering
 * Institution:    Universidad Politécnica de San Luis Potosí
 *   Professor:    Juan Carlos González Ibarra
 * Description:    F# language program to perform different set operations.
 *                
 *  Written:       14/09/2020


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

##Solutions
I found an equivalent method for performing the Symmetric  Difference in F# at <a href="https://rosettacode.org/wiki/Symmetric_difference#F.23" target="\_blank"> (Symmetric Difference in F#).
In this method, the summation of two differences must be executed in order for this method to be equivalent to other programming languages.

## License
[MIT](https://choosealicense.com/licenses/mit/)

## Source Code

```F#

# - Program.fs *- coding: utf-8 -*-
open System

//  Define Three sets
let A = Set.empty.Add(1).Add(2).Add(3).Add(4). Add(5)
let B = Set.empty.Add(3).Add(4).Add(5).Add(6). Add(7)
let C = Set.empty

[<EntryPoint>]
let main argv =
    printfn"\n- Conjuntos\n"
    printfn"Set A: %A" A
    printfn"Set B: %A" B
    printfn"Set C: %A" C

    printfn"\n- Pertenencia\n"
    let pertenencia=
        if A.Contains 1 then printfn(" 1 exists in A")  //  A conditional checks if one element is a member of a given Set
        if not (A.Contains 1) then printfn("1 does not exist in A")
        if A.Contains 10 then printfn("10 exists in A")
        if not (A.Contains 10) then printfn ("10 does not exist in A")

    
    printfn"\n- Transformar Conjunto\n"
    let transformarConj=
        let A = Set.empty.Add(1).Add(2). Add(3)
        printfn"Set A: %A" A
        let B = Set.empty.Add(1).Add(2).Add(3).Add(4). Add(5)
        printfn"Set B: %A" B
        let C = Set.ofList(Seq.toList "Hello World")    //  A set is declared by transforming a string to a List and then to a Set
        printfn"Set C: %A" C
   
    printfn"\n- Quitar\n"
    let quitar=
        let A = Set.empty.Add(0).Add(1).Add(2).Add(3).Add(4).Add(5). Add(6)
        printfn"Set A: %A" A
        let A = A.Remove (2)    //  An element is removed from a Set
        printfn"Set A after removal of the number 2: %A" A
    
    printfn"\n- Clear Set\n"
    let clearSet=
        let A = Set.empty.Add(0).Add(1).Add(2).Add(3).Add(4). Add(5)
        printfn"Set A: %A" A
        let A = Set.empty   //  Every element from a Set is removed
        printfn"Set A cleared: %A" A

    printfn"\n- Copy Set\n"
    let copiar=
        let A = Set.empty.Add(1).Add(2).Add(3).Add(4). Add(5)
        let B = A           //  A set is copied to an empty set
        printfn"Set A = %A, compare set B = %A"A B

    printfn"\n- Add element to Set\n"
    let agregar=
        let B = B.Add(987)  //  An element is added to a Set
        printfn"The new set B: %A" B
     
    (*---------------------------------------------------------
     *  Set Operations
     *---------------------------------------------------------*)

    //  Union
    printfn"\n- Union\n"
    let union= 
        let A = Set.empty.Add(1).Add(2).Add(3).Add(4). Add(5)
        let B = Set.empty.Add(3).Add(4).Add(5).Add(6). Add(7)
        printfn"The Union %A " (Set.union A B)   //  Union Operation is executed to both sets 
        printfn"The Union %A " (A + B)
    
    //  Intersection
    printfn"\n INtersection\n"
    let interseccion=
        let A = Set.empty.Add(1).Add(2).Add(3).Add(4). Add(5)
        let B = Set.empty.Add(3).Add(4).Add(5).Add(6). Add(7)
        printfn"The Intersecion %A " (Set.intersect A B)    //  Intersect Operation is executed to both sets 
    
    //  Difference
    printfn"\n Difference\n"
    let diferencia=
        let A = Set.empty.Add(1).Add(2).Add(3).Add(4). Add(5)
        let B = Set.empty.Add(3).Add(4).Add(5).Add(6). Add(7)
        printfn"The Difference %A " (Set.difference A B)    //  Difference Operation is executed to both sets 
        printfn"The Difference %A " (A - B)

    printfn"\n Symmetric Difference\n"
    let simetrica=
        let A = Set.empty.Add(1).Add(2).Add(3).Add(4). Add(5)
        let B = Set.empty.Add(3).Add(4).Add(5).Add(6). Add(7)
        let C = Set.empty
        printfn"Set A: %A" A
        printfn"Set B: %A" B
        printfn"Set C: %A" C
        printfn"The Symmetric_Difference A-B: %A\n" ((A-B)+(B-A))
        printfn"The Symmetric_Difference B-A: %A\n" ((B-A)+(A-B))
        printfn"The Symmetric_Difference A-C: %A\n" ((A-C)+(C-A))
        printfn"The Symmetric_Difference B-C: %A\n" ((B-C)+(C-B))

    let subconjunto=
        let B = Set.empty.Add(1).Add(2).Add(3).Add(4). Add(5).Add(6).Add(7).Add(8). Add(9)
        let A = Set.empty.Add(1).Add(2).Add(3).Add(4). Add(5)
        printfn"Set A: %A" A
        printfn"Set B: %A" B
        if A.IsSubsetOf B then printfn("A is a subset of B")     //  The subset operation is performed with a conditonal 
        if not (A.IsSubsetOf B) then printfn ("A is not a Subset of A")
    
    // Superset
    let superconjunto=
        let B = Set.empty.Add(1).Add(2).Add(3).Add(4). Add(5).Add(6).Add(7).Add(8). Add(9)
        let A = Set.empty.Add(1).Add(2).Add(3).Add(4). Add(5)
        printfn"Set A: %A" A
        printfn"Set B: %A" B
        if B.IsSupersetOf A then printfn("B is a Superset of A")     //  The superset operation is performed with a conditonal 
        if not (B.IsSupersetOf A) then printfn ("B is not a Superset of A")
    0 // return an integer exit code


