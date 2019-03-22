using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace CoinFlipper
{
    class Program
    {
        static void Main(string[] args) {
            int flipNumber;
            string[] Outcome = new string[2];
            Outcome[0] = "H";
            Outcome[1] = "T";
            int numberOfH = new int();
            int numberOfT = new int();
            Console.WriteLine("How Many Flips?");
            flipNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(flipNumber + " flips coming right up!");
            for (int i = 0; i < flipNumber; i++) {
                int NumberSelect;
                Random rnd = new Random();
                NumberSelect = rnd.Next(0, 2);
                Console.WriteLine(Outcome[NumberSelect]);

                if (NumberSelect == 0) {
                    numberOfH++;
                }
                else {
                    numberOfT++;
                }
            }
            Console.WriteLine("Heads: " + numberOfH + ", Tails: " + numberOfT);
            Console.WriteLine("Again? y or n?");

            if (Console.ReadLine() == "y")
            {
                Main(Outcome);
            }
            else {
                return;
            }
            
        }
    }
}
