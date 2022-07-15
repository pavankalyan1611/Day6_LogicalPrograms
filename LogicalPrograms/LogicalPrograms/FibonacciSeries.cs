using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        public FibonacciSeries()
        {
            Console.WriteLine("Welcome to Fibonacci Series Problem:\n");
        }
        public void Fibonacci()
        {
            Console.WriteLine("Enter The Number");
            int fibonacci = Convert.ToInt32(Console.ReadLine());
            int First_Num = 0;
            int Second_Num = 1;
            int Third_Num;
            Console.Write("Fibonacci Series:\t");
            Console.Write(First_Num +" ");
            Console.Write(Second_Num+" ");

            for (int i = 2; i < fibonacci; i++)
            {
                Third_Num = First_Num + Second_Num;
                Console.Write(Third_Num+" ");
                First_Num = Second_Num;
                Second_Num = Third_Num;
            }
        }
    }
}
