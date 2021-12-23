using System;
using static System.Console;
using System.Text;
using System.Linq;

namespace Calculator
{
    public class CalculatorProgram
    {
        public static double num1;
        public static double num2;
        public static double result = 0;


        static void Main(string[] args)
        {
            bool isAlive = true;
            WriteLine("\n");
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine(String.Format("{0," + WindowWidth / 2 + "}", "*This is a calculator made by Maryam Rezaee* "));
            ResetColor();

            //This is the menu for the calculator.  
            while (isAlive)
            {
                WriteLine("\n Please choose one of the operator below to calculate the result or enter e to exit the program" +
                "\n \n +" +
                "\n -" +
                "\n *" +
                "\n /" +
                "\n e to exit the program \n");

                //User selection for the desired operator.
                //Operator menu will be Alive until user want to exit the program(by entering e)       
                char operat = ReadLine()[0];
                UserInput();
                switch (operat)
                {
                    case '+':
                        Clear();
                        WriteLine("The result is :" +  Addition(num1, num2) + "\n\nPlease ENTER to coutiue");
                        
                        break;

                    case '-':
                        Clear();
                        WriteLine("The result is :" + Subtraction(num1, num2) + "\n\nPlease ENTER to coutiue");

                        break;
                    case '*':
                        Clear();
                        WriteLine("The result is :" + Multiplication(num1, num2) + "\n\nPlease ENTER to coutiue");
                        break;
                    case '/':
                        Clear();
                        WriteLine("The result is :" + Division(num1, num2) + "\n\nPlease ENTER to coutiue");
                        break;
                    case 'e':
                        Clear();
                        ForegroundColor = ConsoleColor.Magenta;
                        WriteLine("\n Thank you for tryig my project");
                        ResetColor();
                        isAlive = false;
                        Environment.Exit(0);

                        break;
                    default:
                        WriteLine(" {0} is not a valid selection, please try again", operat);
                        break;

                }
                //WriteLine("\n The result is {0} ", result,  "\n Please ENTER to continu");
                ReadKey();
                Clear();
            }


        }
        //This method will take the user's inputs, which will be used later in the program, for calculation. 
        public static void UserInput()
        {
            WriteLine("Please enter your first number :");
            num1 = Double.Parse(ReadLine());
            WriteLine("Please enter your second number :");
            num2 = Double.Parse(ReadLine());
        }

        //Addition of the two numbers entered by user.
        public static double Addition(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }

        //overloading Addition method with parsing an array as parameter
        public static double Addition(double[] nums)
        {
            double result = 0; 
            for ( int i = 0; i < nums.Length; i++)
            {
                result += nums[1];
            }
            return result;
        }

        //Addition of the two numbers entered by user.
        public static double Subtraction(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }
        //overloading Subtraction method with parsing an array as parameter
        public static double Subtraction(double[] nums)
        {
            double result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result -= nums[1];
            }
            return result;
        }

        //Multiplication of the two numbers entered by user.
        public static double Multiplication(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }

        //Division of the two numbers entered by user.
        public static double Division(double num1, double num2)
        {
            double result = num1 / num2;
            try
            {
               

                if (Double.IsInfinity(result))
                {
                    throw new ArgumentException("Division by zero is not allowed, please try again.");
                }
              // return result;
 
            }

            catch (ArgumentException e)
            {
                WriteLine(e.Message);
            }
            
            return result;

        }
         


        }
    }