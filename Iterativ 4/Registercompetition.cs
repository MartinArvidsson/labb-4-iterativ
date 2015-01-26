using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterativ_4
{
    class Registercompetition
    {
        AddTeam getTeam = new AddTeam();
        public bool competitionExist = false;
        private int register;

        public void registerBarr() //Fråga om laget ska registreras på genen, svara ja eller nej enbart i dagsläget
        {
            Console.WriteLine("Det finns {0} aktivt lag i dagsläget vill du att {1} ska registeras på grenen?\n1.Ja?\n2.Nej",getTeam.UserInput, getTeam.TeamName);
            register = int.Parse(Console.ReadLine());
            if(register == 1)
            {
                Console.WriteLine("{0} är nu anmält på grenen", getTeam.TeamName);
            }
            if(register == 2)
            {
                Console.WriteLine("Registeringen avbröts");
            }
            if(register <1 || register >2)
            {
                Console.WriteLine("inget korrekt alternativ angavs Programmet stängs av,");
            }
            competitionExist = true;
        }
        public void registerGymnastic()
        {
            Console.WriteLine("Det finns {0} aktivt lag i dagsläget vill du att {1} ska registeras på grenen? \n1.Ja \n2.Nej",getTeam.UserInput, getTeam.TeamName);
            register = int.Parse(Console.ReadLine());
            if (register == 1)
            {
                Console.WriteLine("{0} är nu anmält på grenen", getTeam.TeamName);
            }
            if (register == 2)
            {
                Console.WriteLine("Registeringen avbröts");
            }
            if (register < 1 || register > 2)
            {
                Console.WriteLine("inget korrekt alternativ angavs");
            }
            competitionExist = true;
        }

    }
}
