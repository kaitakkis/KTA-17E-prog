using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allahindluse_programm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("See on allahindluse arvutamise programm.");
            Console.Write("Sisesta summa: ");

            Console.WriteLine();
            string input = Console.ReadLine();

            int number = int.Parse(input);

            if (number < 50 || number < 250)
            {
                Console.WriteLine();
                Console.WriteLine("Tavakliendi allahindlus: 10%");
                Console.WriteLine($"Tasuda: {number * 0.9}");
                Console.WriteLine("Püsikliendi allahindlus: 20%");
                Console.WriteLine($"Tasuda: {number * 0.8}");
            }

            if (number == 250 || number < 350)
            {
                Console.WriteLine();
                Console.WriteLine("Tavakliendi allahindlus: 20%");
                Console.WriteLine($"Tasuda: "{number * 0.8}");
                Console.WriteLine("Püsikliendi allahindlus: 30%");
                Console.WriteLine($"Tasuda: {number * 0.7"}");


             }


            Console.ReadLine();
        }
    }
}
