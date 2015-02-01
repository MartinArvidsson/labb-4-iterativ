using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterativ_4
{
    class Registercompetition
    {
        //AddTeam getTeam = new AddTeam();
        public bool competitionExist = false;
        public int register = 0;
        public static string CBarr;
        public static string CGymnastik;
        public static bool BarrExist = false;
        public static bool GymnExist = false;

        public void registerBarr() 
        {
            try
            {
                Console.WriteLine("Det finns {0} aktivt lag i dagsläget vill du att {1} ska registeras på grenen?\n1.Ja?\n2.Nej", AddTeam.RegistredTeams, AddTeam.TeamName);
                if(register == 0)
                { 
                    register = int.Parse(Console.ReadLine());
                }
                if (register == 1)
                {
                    Console.WriteLine("{0} är nu anmält på grenen barr", AddTeam.TeamName);
                    CBarr = "barr";
                    competitionExist = true;
                    BarrExist = true;
                }
                if (register == 2)
                {
                    Console.WriteLine("Registeringen avbröts");
                }
                if (register < 1 || register > 2)
                {
                    Console.WriteLine("inget korrekt alternativ angavs Programmet stängs av");
                }
                
            }
            catch
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Error inget nummer angavs");
                Console.ResetColor();
            }
        }
        public void registerGymnastic()
        {
            try
            {
                Console.WriteLine("Det finns {0} aktivt lag i dagsläget vill du att {1} ska registeras på grenen? \n1.Ja \n2.Nej", AddTeam.RegistredTeams, AddTeam.TeamName);
                if (register == 0)
                {
                    register = int.Parse(Console.ReadLine());
                }
                if (register == 1)
                {
                    Console.WriteLine("{0} är nu anmält på grenen Gymnastik", AddTeam.TeamName);
                    CGymnastik = "gymnastik";
                    competitionExist = true;
                    GymnExist = true;
                }
                if (register == 2)
                {
                    Console.WriteLine("Registeringen avbröts");
                }
                if (register < 1 || register > 2)
                {
                    Console.WriteLine("inget korrekt alternativ angavs");
                }
                
            }
            catch
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Error inget nummer angavs");
                Console.ResetColor();
            }
        }
    }
}
