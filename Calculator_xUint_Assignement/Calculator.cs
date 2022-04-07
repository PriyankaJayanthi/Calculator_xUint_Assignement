using System;

// Calculator program for xunit test cases.
//2022/04/04 JPRIYANKA

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
                Console.WriteLine(" 1:Addition" + "\n 2:Subtration" + "\n 3:Multiplication" + "\n 4:Divison" + "\n 5:Int Addition" + "\n 6:Int Subtration" );
                int.TryParse(Console.ReadLine(), out int selection);
                double[] addArray = new double[] { 2.5, 4, 6.4, 8 };
                double[] subArray = new double[] { -12.5, -3, 5, 24 };
                int[] addArray1 = new int[] { 2, 5, 12, 34 };
                int[] subArray1 = new int[] { 23, 12, 14, 6 };
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
                    case 5:
                        Console.Clear();
                        result = Addition(addArray1);
                        output = "Int Addition result is:" + result;
                        break;
                    case 6:
                        Console.Clear();
                        result = Subtraction(subArray1);
                        output = "Int Subtraction result is :" + result;
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
        //Overloaded method to perform Addition
        public static double Addition(double[] addArray)
        {
            double result = 0;
            for (int i = 0; i < addArray.Length; i++)
            {
                result += addArray[i];
            }
            return result;

        }
        public static int Addition(int[] addArry1)
        {
            int result = 0;
            for (int i = 0; i < addArry1.Length; i++)
            {
                result += addArry1[i];

            }
            return result;
        }
        //Overloaded method to perform subration
        public static double Subtraction(double[] subArray)
        {
            double result = 0;
            for (int i = 0; i < subArray.Length; i++)
            {
                result -= subArray[i];
            }
            return result;

        }
        public static int Subtraction(int[] subArry1)
        {
            int result = 0;
            for (int i = 0; i < subArry1.Length; i++)
            {
                result -= subArry1[i];

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