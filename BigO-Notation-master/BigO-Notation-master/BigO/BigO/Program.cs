using System;
using System.Linq;

namespace BigO
{
    class Program
    {
        //Created by Beck.
        static void Main(string[] args)
        {
            //Customisation.
            Console.Title = "BigO Notation V3.1 by Beck";
            Console.ForegroundColor = ConsoleColor.Green;
       
            //Calling EnterValue class to start the solutions process.
            EnterValue();

            Console.ReadLine();
        }

        static string EnterValue()
        {
            try
            {
                Console.Clear();
                //Taking the user's input.
                Console.WriteLine("Please enter a numeric value (10000 maximum)");
                string EnteredValue = Console.ReadLine();
                if (Valid(EnteredValue) == false)
                {
                    //Asking user to enter a value if value entered is invalid.
                    return EnterValue();
                }
                else
                {
                    //Outputting the different types of notation.
                    Output(Convert.ToDouble(EnteredValue));
                    return EnterValue();
                }
            }
            catch
            {
                return EnterValue();
            }
        }

        static bool CharacterValidation(string EnteredValue)
        {
            try
            {
                //Validating the string inputted has valid characters.
                string TextCharacters = ("0123456789.-");
                char[] TextCharactersChar = TextCharacters.ToCharArray();
                char[] Validator = Convert.ToString(EnteredValue).ToArray();
                bool Valid = false;
                for (int i = 0; i < Convert.ToString(EnteredValue).Length; i++)
                {
                    for (int z = 0; z < 12; z++)
                    {
                        Valid = false;
                        if (Validator[i] == TextCharactersChar[z])
                        {
                            Valid = true;
                            break;
                        }
                    }
                    if (Valid == false)
                    {
                        return false;
                    }
                }
                if (Valid == true)
                {
                    //If the string inputted is valid "true" is returned.
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        static bool DoubleValidation(string EnteredValue)
        {
            try
            {  
                //Validating that the value entered by the user is double/correct format.
                if (double.TryParse(EnteredValue, out double Checker) == true)
                {
                    //If the string inputted is double, then "true" is outputted.
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        static bool Valid(string EnteredValue)
        {
            //Validating that the user's input is approved by two forms of validation.
            if (CharacterValidation(EnteredValue) == true & DoubleValidation(EnteredValue) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        static string Output(double value)
        {
            Console.Clear();

            //Outputting the numbers returned from the classes created.
            Console.WriteLine("The numeric value you have entered is " + value);
            Console.WriteLine(ConstantTime(value));
            Console.WriteLine(LinearTime(value));
            Console.WriteLine(PolynomialTime(value));
            Console.WriteLine(ExponentialTime(value));
            Console.WriteLine(LogarithmicTime(value));
            Console.WriteLine();

            //Asking the user if they want to enter a new value.
            return Iteration();
        }

        static string Iteration()
        {
            try
            {
                //Asking the user's input, and converting it to uppercase.
                Console.WriteLine("Task completed, would you like to enter a new number (Y/N)");
                string Answer = Console.ReadLine().ToUpperInvariant();
                //Checking the user's input.
                if (Answer == "Y".ToString())
                {
                   Console.Clear();
                   return EnterValue();
                }
                if (Answer == "N")
                {
                    Exit();
                    return "";
                }
                else
                {
                    Console.Clear();
                    return Iteration();
                }
            }
            catch
            {
                return Iteration();
            }
        }

        public static void Exit()
        {
            //Informing the user the application is closing, and exiting the environment.
            Console.Clear();
            Console.WriteLine("Shutting down. Thanks for using the application created by Beck");
            System.Threading.Thread.Sleep(2500);
            Environment.Exit(0);
        }
        
        static string ConstantTime(double value)
        {
            try
            {
                {
                    //O(1) Constant Time
                    double timeComplexity = 0;
                    double y = (2 * value) + 3;
                    timeComplexity++;
                    return ("Notation 0(1) = " + timeComplexity);
                }
            }
            catch
            {
                return "Notation 0(1) = Error";
            }
        }

        static string LinearTime(double value)
        {
            try
            {
                if (value <= 10000)
                {
                    //O(n) Linear Time
                    double timeComplexity = 0;
                    for (int k = 0; k < value; k++)
                    {
                        timeComplexity++;
                    }
                    return "Notation 0(n) = " + timeComplexity;
                }
                else
                {
                    return "Notation 0(n) = Request timed out, value was too large to process";
                }
            }
            catch
            {
                return "Notation 0(n) = Error";
            }
        }

        static string PolynomialTime(double value)
        {
            try
            {
                if (value <= 10000)
                {
                    //O(n^2) Polynomial Time
                    double timeComplexity = 0;
                    for (int k = 0; k < value; k++)
                    {
                        for (int j = 0; j < value; j++)
                        {
                            timeComplexity++;
                        }
                    }
                    return ("Notation 0(n^2) = " + timeComplexity);
                }
                else
                {
                    return "Notation 0(n^2) = Request timed out, value was too large to process";
                }                
            }
            catch
            {
                return "Notation 0(n^2) = Error";
            }
        }

        static string ExponentialTime(double value)
        {
            try
            {
                if (value <= 10000)
                {
                    //O(2^n) Exponential Time
                    double timeComplexity = 0;
                    timeComplexity = Math.Pow(2, value);
                    return ("Notation 0(2^n) = " + timeComplexity);
                }
                else
                {
                    return "Notation 0(2^n) = Request timed out, value was too large to process";
                }
            }
            catch
            {
                return "Notation 0(2^n) = Error";
            }
        }

        static string LogarithmicTime(double value)
        {
            try
            {
                //if a value of < 0 is inputted, then a math error would occur.
                if (value >= 0 & value <= 10000)
                {
                    //O(log n) Logarithmic Time
                    double timeComplexity = 0;
                    timeComplexity = Math.Log(value, 2);
                    return ("Notation 0(log n) = " + timeComplexity);
                }
                if (value > 1000)
                { 
                    return "Notation 0(log n) = Request timed out, value was too large to process";
                }
                else
                {
                    return "Notation 0(log n) = N/A";
                }
            }
            catch
            {
                return "Notation 0(log n) = Error";
            }
        }
    }
}
