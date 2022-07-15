using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class StopWatch
    {
        public StopWatch()
        {
            Console.WriteLine("Welcome to Stop Watch Problem:\n");
        }
        public void stopwatch()
        {

            Console.WriteLine("Press Enter to start");
            Console.ReadLine();
            DateTime start = DateTime.Now;

            Console.WriteLine("Press Enter to stop");
            Console.ReadLine();
            DateTime stop = DateTime.Now;

            Console.WriteLine("Time Duration: " + (stop - start));

        }
    }            
}
