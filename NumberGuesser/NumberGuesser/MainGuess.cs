using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class MainGuess
    {
        public static int TopValue = new int();

        public static int BottomValue = new int();

        public static int CurrentValue = new int();

        public static bool InGame = false;

        public static void HighGuess()
        {
            if (InGame)
            {
                TopValue = CurrentValue;

                var RandomGuess = new Random();

                CurrentValue = RandomGuess.Next(BottomValue, TopValue);
            }
        }

        public static void LowGuess()
        {
            if (InGame)
            {
                BottomValue = CurrentValue;

                var RandomGuess = new Random();

                CurrentValue = RandomGuess.Next(BottomValue, TopValue);
            }
        }

        public static void CorrectGuess()
        {
           InGame = false;
        }

        public static void StartGame()
        {
            TopValue = 101;

            BottomValue = 0;

            InGame = true;

            var RandomGuess = new Random();

            CurrentValue = RandomGuess.Next(BottomValue, TopValue);
        }


    }
}
