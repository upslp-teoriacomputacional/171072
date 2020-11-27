(*
 * *****************************************************************************
 *        Name:    Rodolfo Emanuel   
 *     Surname:    Vázquez Reyes
 *          ID:    171072
 *       Major:    IT Engineering
 * Institution:    Universidad Politécnica de San Luis Potosí
 *   Professor:    Juan Carlos González Ibarra
 * Description:    F# language program to show how does a Turing Machine work
 *                
 *  Written:       26/11/2020
 *  Last updated:  26/11/2020
 **************************************************************************** *)

open System

let turingM  =
    let state = None    //  States from the TM
    let blank = None    //  Blank Symbol from tape's Alphabet
    let rules = []      //  Transition Rules
    let tape = []       //  Tape
    let final = None    //  Valid State &|or Final State 
    let pos = 0         //  Next position from TM

    let st = state  
    
    (*
        ------------------------------------
        If a variable is zero, empty or None 
        then it is considered as False.
        -------------------------------------
        The following if statement will
        return true if the condition is False.
    *)
    
    if not tape then //  If tape is true or NOT EMPTY, it will empty the tape. 
        tape = [blank]
    if pos < 0 then  //  If the position is before 0, the new position will be the length of the tpae
        pos = pos + (tape.Length)
    if pos > = (tape.Length) or pos < 0 then // If the position is after the length of the tape or before 0, it raises an Exception
        raise (OuterError("Wrong Position Inizialization"))
   
    let rules = dict[s0;;;]     //  A dictionary is defined.
    let inventory = Dictionary()
    inventory.Add("Apples", 0.33)






[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
