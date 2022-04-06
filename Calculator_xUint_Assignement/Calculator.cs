using System;

namespace Calculator_xUnit_Assignement
{
    public class calculatorTest
    {
        public static void Main(string[] args)
        {
            bool isAlive = true;
            while (isAlive)
            {
                // Menu Creation
                Console.WriteLine("Welcom to Caluclator program:\n Please select the one of the folling option:");
                Console.WriteLine(" 1:Addition" + "\n 2:Subration" + "\n 3:Multiplication" + "\n 4:Divison");
                // User to entere first input
                int.TryParse(Console.ReadLine(), out int selection);
                double[] addArray = new double[] { 2, 4, 6, 8 };
                double[] subArray = new double[] { -12, -3, 5, 24 };
                double result = 0;
                var output = "";

                //-selection

                switch (selection)
                {
                    case 1:
                        Console.Clear();
                        result = Addition(addArray);
                        output = "Addition result is: " + result;
                        break;
                    case 2:
                        Console.Clear();
                        result = Subtraction(subArray);
                        output = "Subtraction result is:" + result;
                        break;
                    case 3:
                        Console.Clear();
                        result = Multiplication(3, 6);
                        output = "Multiplication result is:" + result;
                        break;
                    case 4:
                        Console.Clear();
                        result = Division(10, 5);
                        output = "Division result is:" + result;
                        break;
                    default:
                        Console.WriteLine("Not a valld selection,try again");
                        break;
                }
                // display result

                Console.WriteLine(output);
                Console.WriteLine("would you like to continue or exit. Enter Any Key - Continue or N - Exit");
                var key = Console.ReadLine().ToUpper();
                if (key == "N")
                {
                    isAlive = false;
                    Console.WriteLine("Thanks for using Caluclator");
                    Console.ReadKey();
                }

            }
        }
        //To perform Addition
        public static double Addition(double[] addArray)
        {
            double result = 0;
            for (int i = 0; i < addArray.Length; i++)
            {
                result += addArray[i];
            }
            return result;

        }
        // To perform subration
        public static double Subtraction(double[] subArray)
        {
            double result = 0;
            for (int i = 0; i < subArray.Length; i++)
            {
                result -= subArray[i];
            }
            return result;

        }
        // To perform multplication
        public static double Multiplication(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }
        // To perform Divison
        public static double Division(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("If num2 is 0 is said to be undefine");
                return 0;
            }
            else
            {
                double result = num1 / num2;
                return result;
            }

        }

    }
}