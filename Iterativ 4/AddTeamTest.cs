using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterativ_4
{
    class AddTeamTest
    {
        public static void Run()
        {
            Console.WriteLine("         ============================================================");
            Console.WriteLine("         |                   TESTER AV ADDTEAM                      |");
            Console.WriteLine("         |                    _________________                     |");
            Console.WriteLine("         ============================================================\n");

            testteam(); 
        }
        static void testteam()
        {
            if (Teamtest1())
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Lyckat! att anmäla 1 lag gick bra\n");
                AddTeam.TeamName = null;
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Fungerar inte, Antal Lag gick inte att registrera");
                Console.ResetColor();
            }

            if (Teamtest2())
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Lyckat! Gick inte att tilldela värde utanför intervallet!\n");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Fungerar inte, Gick att anmäla värde utanför intervallet..");
                Console.ResetColor();
            }

        }
        static bool Teamtest1() 
        {
            Console.WriteLine("Test av registrering av 1 lag");
            AddTeam addTeam = new AddTeam();
            addTeam.UserInput = 1;
            AddTeam.TeamName = "Testlag123";

            addTeam.addTeam();
            

            if (addTeam.UserInput <= addTeam.maximumTeams)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static bool Teamtest2() 
        {
            Console.WriteLine("Testar att anmäla antal lag utanför intervallet");
            AddTeam addTeam = new AddTeam();

            addTeam.UserInput = 5;

            addTeam.addTeam();

            if (addTeam.UserInput <= addTeam.maximumTeams)
            {
                return false;
            }
            else
            {
                return true;
            }


        }
    }
}
