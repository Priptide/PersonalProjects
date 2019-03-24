using System;

namespace FactoralNumber
{
    class Program
    {
        static void Main()
        {
            int FinalAnswer = 1;
            int inputAnswer = new int();
            Console.WriteLine("Enter a number to find it's factorial! [1 - 12]");
            string inputString = Console.ReadLine();
            try
            {
                inputAnswer = Convert.ToInt32(inputString);
                if(inputAnswer > 12)
                {
                    Main();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Main();
            }

            for(int i = 1; i <= inputAnswer; i++)
            {
                FinalAnswer = FinalAnswer * i;
            }

            Console.WriteLine("Answer: " + FinalAnswer.ToString());
            Console.WriteLine("Again y or n?");

            var answer = Console.ReadLine();

            if (answer == "y")
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
