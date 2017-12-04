Jack O'Hare
Comp 163 
Extra Credit Project
12/4/2017

For my project, I decided to make a roman numeral calculator in C#. One error i know of that ideally would be fixed in the future is that
when calculating a number over 4000, an error is thrown. Attempting to solve an equation that results in a negative number also currently 
throws an index out of bounds error. There are two additional classes that make up this program called RomanNumber and Equation. RomanNumber 
is used to store the string value of a roman numeral as well as the arabic version (integer), and contains the conversion methods used to 
convert to and from arabic and roman. The other class, Equation is used to create a new equation with the user-input. It contains two 
instances of the RomanNumber class, and calls the conversion methods in that class to compute the answers to the requested equation. 
In the interface, there are two output fields, the top shows the user input roman numeral, and the answer in roman numerals. The bottom shows
the same as the top only converted to arabic numbers. 