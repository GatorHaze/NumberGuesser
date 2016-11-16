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


            var num = 0;
            var attempts = 0;
            var lastNum = 0;
            var maxtries = 5;


            while (attempts < maxtries && getRandomNumber != num)
            {
                lastNum = num;
                Console.WriteLine("Please enter a random number between 1 and 100");
                var newNum = int.TryParse(Console.ReadLine(), out num);
                attempts++;


                if (attempts >= maxtries)
                {
                    Console.WriteLine("Your tries are up, and you Lose");
                    Console.ReadLine();

                }

                else if (num == getRandomNumber)
                {
                    Console.WriteLine("Awesome! You WIN!!!");
                    Console.ReadLine();
                }

                if (lastNum > getRandomNumber && num > lastNum)
                { Console.WriteLine("Still need to go lower!"); }


                else if (lastNum < getRandomNumber)
                {
                    Console.WriteLine($"Fell a little short, you need to go higher");
                }
                else if (lastNum > getRandomNumber)
                {
                    Console.WriteLine($"{num} is too high, calm down!");
                }
            }
        }
    }
}