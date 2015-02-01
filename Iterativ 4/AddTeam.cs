using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterativ_4
{
    class AddTeam
    {
        public int maximumTeams = 2;
        public int UserInput;
        public static string TeamName;
        public static int RegistredTeams;
        public bool TeamExist = false;
        public void addTeam()
        {
            try
            { 
                if(UserInput > 0)
                {

                    if (UserInput < maximumTeams) 
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Tack! {0} Lag är nu registrerade", UserInput);
                        RegistredTeams = UserInput;
                        Console.ResetColor();
                        if (TeamName == null)
                        {
                            Console.WriteLine("Var vänlig och ange lagnamn");
                            TeamName = Console.ReadLine();
                        }
                        Console.WriteLine("Tack {0}, är nu ett registrerat lag!",TeamName);
                        Console.ResetColor();
                        TeamExist = true;
                    
                    }
                    else  
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Fel! 1  Lag enbart! Programmet stängs nu av!");
                        Console.ResetColor();
                    }
                }
                else 
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Fel! mer än 0 Lag måste delta! Programmet stängs nu av!");
                    Console.ResetColor();
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
