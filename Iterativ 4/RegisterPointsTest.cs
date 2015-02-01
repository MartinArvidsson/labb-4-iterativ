using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterativ_4
{
    class RegisterPointsTest
    {
        public static void Run()
        {
            Console.WriteLine("         ============================================================");
            Console.WriteLine("         |                   TESTER AV REGPOINT                     |");
            Console.WriteLine("         |                    _________________                     |");
            Console.WriteLine("         ============================================================\n");

            testpoint(); 
        }
        static void testpoint()
        {
            if (pointtest1())
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Lyckat! Gick att registrera nummer inom intervallet\n");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Fungerar inte, Gick inte att ange poäng");
                Console.ResetColor();
            }

            if (pointtest2())
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Lyckat! Gick inte registrera poäng!\n");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Fungerar inte, Gick att registera värde utanför intervallet..");
                Console.ResetColor();
            }
        }
            
            
            static bool pointtest1() 
        {
            Console.WriteLine("Testar att registrera nummer inom intervallet");
            RegisterPoints testpoint = new RegisterPoints();
            testpoint.judgeOne = 5;
            testpoint.judgeTwo = 5;
            testpoint.judgeThree = 5;
            testpoint.registerPoints();

            if (testpoint.ProgDone == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static bool pointtest2() 
        {
            Console.WriteLine("Testar att registrera nummer Utanför intervallet");
            RegisterPoints testpoint = new RegisterPoints();
            testpoint.judgeOne = 47;
            testpoint.judgeTwo = 15;
            testpoint.judgeThree = 70;
            testpoint.registerPoints();

            if (testpoint.ProgDone == false)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
