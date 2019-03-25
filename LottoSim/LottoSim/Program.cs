using System;

namespace LottoSim
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Start Lotto? [type y to generate numbers]");
            string inputStr = Console.ReadLine();
            
            if(inputStr == "y")
            {
                Random rnd = new Random();

                for(int i = 0; i < 6; i++)
                {
                    Console.WriteLine(rnd.Next(1, 50));
                }

                Console.WriteLine("Complete! Again? [y to retry]");
            }
            else
            {
                return;
            }

            string inputStrN = Console.ReadLine();

            if (inputStr == "y")
            {
                Main();
            }
            else
            {
                return;
            }
        }
    }
}
