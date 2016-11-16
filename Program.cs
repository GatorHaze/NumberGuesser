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
            int randomNumber = randomNum.Next(0, 100);
            Console.WriteLine($"The number {randomNumber} was generated!");

            var input = 0;
            var attempts = 0;
            var lastNum = 0;
            var maxatt = 5;

            while (attempts < maxatt && input != randomNumber)
            {
                lastNum = input;
                Console.WriteLine("Feeling Lucky? Enter a random number between 1 and 100");
                var newNum = int.TryParse(Console.ReadLine(), out input);
                Console.WriteLine((1 + (attempts++)) + " attempts so far");

                if (lastNum < randomNumber)
                {
                    Console.WriteLine($"{input} Fell short, you need to go higher");
                }
                else if (lastNum > randomNumber)
                {
                    Console.WriteLine($"{lastNum} is too high, calm down!");
                }
                else
                {
                    Console.WriteLine("try again!");
                }
            }

            if (input == randomNumber)
            {
                Console.WriteLine("Congradulations you are a GENIUS!!!!!");
                Console.ReadLine();
            }
            if (attempts >= maxatt)
            {
                Console.WriteLine("Your tries are up, you Lose!" + " The number was " + randomNumber);
                Console.ReadLine();
            }
        }
    }  
}