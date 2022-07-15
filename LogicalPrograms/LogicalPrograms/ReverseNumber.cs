using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ReverseNumber
    {
        public ReverseNumber()
        {
            Console.WriteLine("Welcome to Reverse Number Problem:\n");
        }
        public void reverseNum()
        {
            Console.WriteLine(" Enter a Num Which You want to Reverse the Num : ");
            int Number = Convert.ToInt32(Console.ReadLine());

            int ReversedNumber = 0;
            string Digits = Convert.ToString(Number);
            for (int i = Digits.Length - 1; i >= 0; i--)
            {
                ReversedNumber += (Number % 10) * (int)Math.Pow(10, i);
                Number = Number / 10;
            }
            Console.WriteLine(" The Reverse number of the Given num Is : " + ReversedNumber);

        }
    }            
}
