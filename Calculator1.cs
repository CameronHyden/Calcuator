using System;
namespace Calculator
{
    public class Calculator1
    {


        public static int add(int firstSum, int secondSum)
        {
            int result = firstSum + secondSum;
            Console.WriteLine(result);
            return result;
        }

        public static int subtract(int firstSum, int secondSum)
        {
            int result = firstSum - secondSum;
            Console.WriteLine(result);
            return result;
        }

        public static int divide(int firstSum, int secondSum)
        {
            int result = firstSum / secondSum;
            Console.WriteLine(result);
            return result;
        }

        public static int times(int firstSum, int secondSum)
        {
           int result = firstSum * secondSum;
            Console.WriteLine(result);
            return result;
        }
        public static void checkIfSquareRoot( string method, int firstSum)
        {
            if(method == "√")
            {
               
                Calculator1.squareRoot(firstSum);
            }
        }
        public static int squareRoot(int firstSum)
        {
            int result = (int)Math.Sqrt(firstSum);
            Console.WriteLine(result);
            Calculator1.exit(1);
            return result;
           
        }
            
        public static void checkOperator(string method, int firstSum, int secondSum)
        {
            switch (method) {
                case "+":
                    Calculator1.add(firstSum, secondSum);
                    break;
                case "-":
                    Calculator1.subtract(firstSum, secondSum);
                    break;
                case "/":
                    Calculator1.divide(firstSum, secondSum);
                    break;
                case "*":
                    Calculator1.times(firstSum, secondSum);
                    break;
                default:
                    Console.WriteLine("sorry I dont accept that operator");
                    break;
            }

        }
        public static void exit(int position)
        {

            Environment.Exit(position);

        }

    }
}

