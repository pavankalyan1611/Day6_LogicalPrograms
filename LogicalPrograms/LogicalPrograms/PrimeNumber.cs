using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public PrimeNumber()
        {
            Console.WriteLine("Welcome to Prime Number Problem:\n");
        }
        public void primeNumber()
        {
            Console.WriteLine("Enter The Number");
            int Num = Convert.ToInt32(Console.ReadLine());

            int j = 0;

            for (int i = 2; i < Num; i++)
            {
                if (Num % i == 0)
                {
                    j = 1;
                    break;
                }
            }
            if (j == 1)            
                Console.WriteLine(Num + "  Not a Prime Number");            
            else            
                Console.WriteLine(Num + "  Is a Prime Number");            
        }
    }            
}
