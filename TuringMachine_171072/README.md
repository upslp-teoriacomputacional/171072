## F# Program about a Turing Machine.

 *              Name:    Rodolfo Emanuel Vázquez Reyes
 *             Major:    IT Engineering
 *       Institution:    Universidad Politécnica de San Luis Potosí
 *         Professor:    Juan Carlos González Ibarra
 *       Description:    F# language program to demonstrate how a Turing Machine Multiplies. 
 *           Written:    26/11/2020

## About this Program 
This was my ninth F# program.

The purpose of this program was to illustrate how a Turing machine works given certain rules. 

Since the previous program was very similar, Stack Rules were added along with some minor changes to the transitionT and transitionT2 variables.

Changing these were not that complex. For me, the real challenge was about implementing the Stack in the recursive fuction. 

For running this program I used .NET tools.
I ran this program from a Git Bash console; the terminal must be opened in the location of the program and .Net must also
be installed on the system. The command "dotnet run" must be used for the program to be executed. 

## Solutions

Since the previous program checked for valid and non valid, this program checks if its empty or if the program has reached an end.
In order for the implemententation of  to be made, concepts and topics regarding PushDown Automatons must be understood. 
I did not understood quite well about mutable variables, and regular expressions were definitely a pain in the neck.


## Link 1
[ This article ](https://www.jquery-az.com/4-demos-python-if-not-and-not-in-operator/#:~:text=In%20Python%2C%20if%20a%20variable,the%20value%20of%20x%20%3D%200.)
simply explains if not statements in Python. 

## Link 2
I found information on how handle Exceptions using the raise function in F# [ Handling Exceptions in F# ](https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/exception-handling/the-raise-function).

## Link 3
This is a [source language](http://t0yv0.blogspot.com/2011/02/home-made-regular-expressions-in-f.html) that shows how to immplement a NFA in F#. First, the regular expressions themselves: the source language can be nicely described with a union type, encompassing the empty string, choice, concatenation, the Kleene star, and a token parser.


## Link 4
I read some examples on forums and I read something about "mutable variables". I learned how to 
use them at [Mutable variables in F#]( https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/values/#:~:text=of%20functional%20programming.-,Mutable%20Variables,be%20modified%20in%20incorrect%20ways. ).

## Link 5
Information about using Lists in F# is found [here.](https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/lists) 


## OUTPUT FROM TERMINAL
After a long, long time, the PDA checker was a success!
It is important to note that this program should work with any string containing an bn characters. 

<img src="images/netrun1.png"> 



## License
[MIT](https://choosealicense.com/licenses/mit/)


## Source Code
```F#
