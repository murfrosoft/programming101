# programming101
A solution to a basic problem in every programming language.

## Goal:
Create a problem that illustrates the core concepts of any programming language.  Problem should require the following elements:
* Formatted output
* Protected numeric inputs
* Conditional Logic
* Sentinel and Counter controlled loops
* Use of arrays/lists
* Creation of a function/method

## Problem Description:
Create a console application that find the average of a set of input grades after the lowest grade is dropped.  This application should do the following:
1. First, prompt the user to enter in the number of grades they wish to average.  If the user enters a non-numeric value, a non-integer value, or a value less than 3, they should be reprompted.
2. Next, prompt the user to enter each grade value as an integer.  If the user enters a non-numeric or non-integer value, they should be reprompted.
3. After all grades have been entered, print to the console each entered grade along with an indicator to which grade was dropped.
4. After all grades have been entered, print to the console the average of all grades, not including the dropped grade, rounded to 2 decimal places.
5. Create an IntPrompt() method/function to help solve this problem.  This function should take a string of prompt text as an input and should return an integer value.  This function should verify that the user input value can be converted to an integer, and should reprompt the user if a non-integer value has been entered.

## Example output:
<pre>
How many grades will you enter: abc
*Invalid input. Try again*
How many grades will you enter: 4.3
*Invalid input. Try again*
How many grades will you enter: 1
*Minimum value of 3 expected*
How many grades will you enter: 4

Enter grade 1: 92
Enter grade 2: 64
Enter grade 3: abc
*Invalid input. Try again*
Enter grade 3: 78.4
*Invalid input. Try again*
Enter grade 3: 77
Enter grade 4: 64

Your grades:
92
64 *dropped*
78
64

Average of grades is 77.67
</pre>
