using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterativ_4
{
    class RegisterPoints
    {
        public int judgeOne = 0;
        public int judgeTwo = 0;
        public int judgeThree = 0;
        public int totalSum;
        public int finalScore;
        public bool ProgDone = false;
        public void registerPoints()
        {
            //Mata in 3 värden, beräkna och presentera det tillsammans med lagnamnet
            try
            {
                if(Registercompetition.BarrExist == true)
                {
                Console.WriteLine("Lag {0} har precis tävlat i {1} dags att ge poäng!", AddTeam.TeamName, Registercompetition.CBarr);
                }
                if(Registercompetition.GymnExist == true)
                {
                  Console.WriteLine("Lag {0} har precis tävlat i {1} dags att ge poäng!", AddTeam.TeamName, Registercompetition.CGymnastik);
                }
                if (judgeOne == 0)
                {
                    Console.WriteLine("Domare nummer 1, var vänlig och ange din poäng 1-10 heltal enbart");
                    judgeOne = int.Parse(Console.ReadLine());
                }
                if (judgeTwo == 0)
                {
                    Console.WriteLine("Domare nummer 2, var vänlig och ange din poäng 1-10 heltal enbart");
                    judgeTwo = int.Parse(Console.ReadLine());
                }
                if (judgeThree == 0)
                {
                    Console.WriteLine("Domare nummer 3, var vänlig och ange din poäng 1-10 heltal enbart");
                    judgeThree = int.Parse(Console.ReadLine());
                }
                if (judgeOne > 0 && judgeOne < 11 && judgeTwo > 0 && judgeTwo < 11 && judgeThree > 0 && judgeThree < 11)
                {
                    totalSum = judgeOne + judgeTwo + judgeThree;
                    ProgDone = true;
                }
                else
                {
                    Console.WriteLine("Någoning blev fel, Domarnas poäng ligger inte inom intervallet");
                    ProgDone = false;
                }

                Console.WriteLine("Lag {0} Fick ihop totalt {1} poäng av maximalt 30", AddTeam.TeamName, totalSum);
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
