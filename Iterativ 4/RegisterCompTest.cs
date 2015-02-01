using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterativ_4
{
    class RegisterCompTest
    {
        public static void Run()
        {
            Console.WriteLine("         ============================================================");
            Console.WriteLine("         |                   TESTER AV REGCOMP                      |");
            Console.WriteLine("         |                    _________________                     |");
            Console.WriteLine("         ============================================================\n");

            testcomp(); 
        }

        static void testcomp()
        {
            if (Comptest1())
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Lyckat! registrera sig på gren gick bra\n");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Fungerar inte, gick inte att registrera");
                Console.ResetColor();
            }

            if (Comptest2())
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Lyckat! Gick inte att registrera gren!\n");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Fungerar inte, Gick att registera gren..");
                Console.ResetColor();
            }

            if (Comptest3())
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Lyckat! registrera sig på gren gick bra\n");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Fungerar inte, gick inte att registrera");
                Console.ResetColor();
            }

            if (Comptest4())
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Lyckat! Gick inte att registrera gren!\n");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Fungerar inte, Gick att registera gren..");
                Console.ResetColor();
            }

        }
        static bool Comptest1() 
        {
            Console.WriteLine("Test av registering av gren inom intervallet gren barr");
            Registercompetition testreg = new Registercompetition();
            testreg.register = 1;
            testreg.registerBarr();
            

            if(testreg.competitionExist == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static bool Comptest2() //Testar att mata in ett felaktigt värde.
        {
            Console.WriteLine("Test av registering av gren utanför intervallet gren barr");
            Registercompetition testreg = new Registercompetition();
            testreg.register = 3;
            testreg.registerBarr();
            

            if (testreg.competitionExist == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool Comptest3() //Testar att lägga till 10 användare
        {
            Console.WriteLine("Test av registering av gren inom intervallet gren gymnastik");
            Registercompetition testreg = new Registercompetition();
            testreg.register = 1;
            testreg.registerGymnastic();


            if (testreg.competitionExist == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static bool Comptest4() //Testar att mata in ett felaktigt värde.
        {
            Console.WriteLine("Test av registering av gren utanför intervallet gren Gymnastik");
            Registercompetition testreg = new Registercompetition();
            testreg.register = 3;
            testreg.registerGymnastic();


            if (testreg.competitionExist == false)
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
