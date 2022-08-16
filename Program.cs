using System;

namespace Calculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstSum = 0;
            int secondSum = 0;
            string method = "";


            Console.WriteLine("Type a number, and then press Enter");
            firstSum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type your operator, and then press Enter");
            method = Console.ReadLine()!;
            Calculator1.checkIfSquareRoot( method, firstSum);          
            Console.WriteLine("Type another number, and then press Enter");
            secondSum = Convert.ToInt32(Console.ReadLine());
            Calculator1.checkOperator(method, firstSum, secondSum); 

        }

  
    }
}