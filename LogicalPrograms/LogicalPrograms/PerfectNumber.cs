using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public PerfectNumber()
        {
            Console.WriteLine("Welcome to Perfect Number Problem:\n");
        }
        public bool Factors(int Number, int Potential_Factor)
        {
            if (Number % Potential_Factor == 0)            
                return true;            
            else            
                return false;            
        }
        public void Perfectnum()
        {
            int Check = 0;
            Console.WriteLine("Enter the num you want to check : ");
            int Number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= Number / 2; i++)
            {
                if (Factors(Number, i))                
                    Check += i;                
            }
            if (Check == Number)            
                Console.WriteLine(Number + " Is a Perfect Number ");            
            else            
                Console.WriteLine(Number + " Is  Not a Perfect Number ");            
        }
    }            
}
