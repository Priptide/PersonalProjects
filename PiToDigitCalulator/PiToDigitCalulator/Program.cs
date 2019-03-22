using System;

namespace PiToDigitCalulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Many Digits Would You Like Pi Too? [1 - 1002]");

            var publicValue = "314159265358979323846264338327950288419716939937510582097494459230781640628620899862803482534211706798214808651328230664709384460955058223172535940812848111745028410270193852110555964462294895493038196 44288109756659334461284756482337867831652712019091 456485669234603486104543266482133936072602491412737245870066063155881748815209209628292540917153643678925903600113305305488204665213841469519415116094330572703657595919530921861173819326117931051185480744623799627495673518857527248912279381830119491298336733624406566430860213949463952247371907021798609437027705392171762931767523846748184676694051320005681271452635608277857713427577896091736371787214684409012249534301465495853710507922796892589235420199561121290219608640344181598136297747713099605187072113499999983729780499510597317328160963185950244594553469083026425223082533446850352619311881710100031378387528865875332083814206171776691473035982534904287554687311595628638823537875937519577818577805321712268066130019278766111959092164201989";

            char[] picollection = new char[1000];

            picollection = publicValue.ToCharArray();

            int NumberToCalc = new int();

            try
            {
                NumberToCalc = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Goodbye!");
                Console.WriteLine("r to restart");

                if (Console.ReadLine() == "r")
                {
                    string[] blank = new string[0];

                    Main(blank);
                }
                else
                {
                    return;
                }
            }

            if(0 < NumberToCalc && NumberToCalc <= 1002)
            {
                string outputS = "";

                for (int i = 0; i <= NumberToCalc; i++)
                {
                    if (i != 1)
                    {
                       outputS  = outputS + picollection[i];
                    }
                    else
                    {
                        outputS = outputS + "." + picollection[i];
                    }
                }

                Console.WriteLine("Output: " + outputS.ToString());
            }
            else
            {
                Console.WriteLine("Too Big!");
            }

            Console.WriteLine("r to restart");

            if (Console.ReadLine() == "r")
            {
                string[] blank = new string[0];

                Main(blank);
            }
            else
            {
                return;
            }
            
            
        }
    }
}
