# Path to program.cs (code)
  BigO-Notation/BigO/BigO/Program.cs
# BigO-Notation Version 3.1
Purpose:
  This project is a console application that carries out five calculations on a users given input.

  The user will be prompted to enter a number(the limit of the number is 10,000 because any higher will crash the program)
  The program then carries out 2 forms of validation, checking that the right characters have been entered e.g. 1234, 
  and that the number entered is in the form of decimal.

  If the user input fails these forms of validation, it will prompt the user to re-enter a number.
  Else if the user enters a valid number, the code will proceed to carry out the calculations on the number N and will output the values.

  The calculations carried out will be the Notations: 0(1), 0(n), 0(n^2), 0(2^n), 0(log n).
  These calculations are also known as (in the same order): Constant time, Linear time, Polynomial time, Exponential time, 
  Logarithmic   time.

  Once the calculations have taken place and been outputted, it will ask the user whether they want to enter a new number.
  If the user enters the letter "y" or "Y", then they will be prompted to enter a new number and the loop will continue from the start.
  Else if the user enters "n" or N, then the application will output "Shutting down. Thanks for using the application created by Beck", 
  wait 2.5 seconds, then close the application.

Versions/patches:
  1.0 - Basic programming complete, all calculations work correctly and output. Success criteria passed.
  
  2.0 - Moved code into seperate functions to make the application easier to understand and more efficient.
      - Also added in one form of validation to check the characters entered by the user.
      
  3.0 - Created a new function that validates that the users input is decimal. (two forms of validation now)
      - Created a new function that checks whether a user wants to enter a new number.
  
  3.1 - Small bug fix/patch
      - When asked whether a user want to enter a new number the program now accepts uppercase and lowercase characers.
      - Added a limit to where users can enter a number above 10,000 but the code returns "request timed out", rather than crashing.
      - Removed a line of code that could be inserted into another line making the code more efficient.
      - Aesthetic features e.g. Title and green text.
