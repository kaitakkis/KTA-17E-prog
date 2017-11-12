using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string selectString;
            int selectInt;

            Console.Clear();

                Console.WriteLine("Test your English. Fill in the gap in the sentence below with a suitable option. Write the number of the correct option (1, 2 or 3) in the answer space below.");
                Console.WriteLine();
                Console.WriteLine("If I had found her address, I __________ her an invitation.");

            while(true)
            {
                Console.WriteLine("\n\r\t(1) will send");
                Console.WriteLine("\n\r\t(2) had sent");
                Console.WriteLine("\n\r\t(3) would have sent");

                Console.WriteLine();
                Console.Write("Answer: ");
                selectString = Console.ReadLine().Trim();

                if(
                   selectString.ToLower() == "3"
                    )
                {
                    Console.WriteLine("\n\r\tCorrect answer! Your score: 1");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }

                if (!int.TryParse(selectString, out selectInt) || selectInt < 3 || selectInt > 3)

                    Console.WriteLine();
                    Console.WriteLine("\tYour asnwer was wrong. Correct answer is 3. Your score: 0");
                    Console.ReadKey();
                    Console.Clear();
                break;

            }
            





            Console.ReadLine();
        }
    }
}
