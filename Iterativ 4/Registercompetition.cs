using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterativ_4
{
    class Registercompetition
    {
        public bool competitionExist = false;
        AddTeam addteam = new AddTeam();
        
        public void registerBarr()
        {
            string teamName = addteam.TeamName;
            Console.WriteLine("Det finns 1 aktivt lag i dagsläget vill du att {0} ska registeras på grenen?",teamName);
        }
        public void registerGymnastic()
        {

        }

    }
}
