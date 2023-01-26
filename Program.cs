using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSpeedTest
{
    internal class Program
    {
        public static void Main()
        {
            // Запросить пользователя для ввода слова, которое нужно набрать. 
            Console.WriteLine("Please enter a word to test your typing speed:");
            string word = Console.ReadLine();

            // Засечь время, необходимое для того, чтобы набрать слово. 
            Stopwatch sw = new Stopwatch();
            sw.Start();

            // Запросить, чтобы пользователь набрал слово. 
            Console.WriteLine("Please type the word:");
            string input = Console.ReadLine();

            // Остановить Stopwatch, чтобы определить, сколько времени ушло.  
            sw.Stop();

            // Прверить, соответсвует ли input word entered by the user to the original word.  
            if (input == word)
            {

                // Calculate and print the typing speed in words per minute (wpm).  
                double wpm = (double)word.Length / sw.Elapsed.TotalMinutes;

                Console.WriteLine("Your typing speed is {0} wpm.", wpm);
            }
            else
            {

                Console.WriteLine("Incorrect spelling!");
            }

            Console.ReadKey();
        }
    }
}
