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
 *  Written:       08/09/2020
 *  Last updated:  12/09/2020
 **************************************************************************** *)

 (*---------------------------------------------------------
 *  Is the Quadratic Allocation Problem NP-Complete or is 
 *  it in P?
 *  Either give a reduction to show it is NP-complete or 
 *  give a polytime algorithm to solve it.
 *---------------------------------------------------------*)

open System

//  Definition of Three sets
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

    (*----------------------------------------------------------------------
     *  I found an equivalent method for performing the Symmetric 
     *  Difference at https://rosettacode.org/wiki/Symmetric_difference#F.23
     *  In this methid, the summation of two differences must be executed 
     *  in order for this method to be equivalent.
     *----------------------------------------------------------------------*)
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
