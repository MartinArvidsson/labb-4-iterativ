using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterativ_4
{
    class Registercompetition
    {

        public void registerCompetition()
        {
            CoursePick = coursePick("Registrera vilken gren som laget ska delta i!\n1: Barr\n2:Gymnastik\nAnnan sport som jag inte kan namn på\n");
                    if (CoursePick == 1)
                    {
                        Console.WriteLine("Du har valt Barr!!");
                    }
                    if (CoursePick == 2)
                    {
                        Console.WriteLine("Du har valt Gymnastik!");
                    }
                    if(CoursePick > 2)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Finns inget commando på det numret stänger av");
                        Console.ResetColor();
                    }
                    if (CoursePick < 1)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Finns inget commando på det numret stänger av");
                        Console.ResetColor();
        }
    }
}
