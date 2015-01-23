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
        public string TeamName;
        public void addTeam()
        {
            
            if(UserInput > 0)
            {

                if (UserInput < maximumTeams) //Kollar om vad användaren matar in är mindre än maxantalet isåfall gör nedanstående
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Tack! {0} Lag är nu registrerade", UserInput);
                    Console.ResetColor();
                    Console.WriteLine("Var vänlig och ange lagnamn");
                    TeamName = Console.ReadLine();
                    Console.WriteLine("Tack {0}, är nu ett registrerat lag!",TeamName);
                    Console.ResetColor();
                    //Kod för att gå tillbaka till startmenyn
                    //Kommer ev. köra den i huvudmenyn
                    
                }
                else //Om man matar in ett för stort värde 
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Fel! 1  Lag enbart! Programmet stängs nu av!");
                    Console.ResetColor();
                }
            }
            else //Om man matar in ett för litet värde 
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Fel! mer än 0 Lag måste delta! Programmet stängs nu av!");
                Console.ResetColor();
            }
        }
    }
}
