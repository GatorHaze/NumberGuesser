using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberguesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNum = new Random();
            int getRandomNumber = randomNum.Next(0, 100);
            Console.WriteLine($"The number {getRandomNumber} was generated!");

          






            //Console.WriteLine("Please enter a random number between 1 and 100");
            var input = Console.ReadLine();
        }
    }
}
