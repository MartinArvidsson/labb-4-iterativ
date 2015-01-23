using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterativ_4
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Analyserat användningsfall, se laborationspappret labb 3 för mer specifikationer
                //Integrationtests integrationtest = new Integrationtests();
                //integrationtest.integrationstester();

                //Test.Run(); //Startar testklassen och kör testerna

                Console.WriteLine("         ============================================================");
                Console.WriteLine("         |                    Hej och välkommen!                    |");
                Console.WriteLine("         |                 Var vänlig och Logga in!                 |");
                Console.WriteLine("         |                  Laboration 4 Iterativ!                  |");
                Console.WriteLine("         ============================================================\n");
                
                logon(false);
            }
        }
        public static void logon(bool loggedin)
        {
            login login = new login(); //Startar en ny loginklass
            AddTeam addTeam = new AddTeam(); //Startar en ny AddUser klass
            Registercompetition register = new Registercompetition();
            RegisterPoints points = new RegisterPoints();
            

            login.userloginInput(loggedin); // kör userloginInput i Login-klassen

            if (login.isUserLoggedIn == true) //Om man lyckas logga in 
            {
                int UserChoice; //Körs detta
                int CoursePick;
                UserChoice = userInput("Väj ett alternativ:\n0: anmäl antal deltagare\n1:Registrera lag på gren\n2:Ge poäng!");
                if (UserChoice == 0)
                {
                    Console.WriteLine("Ange antal lag som deltar (max 1 i dagsläget)");
                    addTeam.UserInput = int.Parse(Console.ReadLine());
                    addTeam.addTeam(); //Startar addTeam i addTeam-klassen.
                    if(addTeam.TeamName != null)
                    {
                        
                        UserChoice = userInput1("Väj ett alternativ:\n1:Registrera lag på gren\n2:Ge poäng!");
                        Console.Clear();
                    }

                }
                if (UserChoice == 1)
                {
                    Console.Clear();
                    CoursePick = coursePick("Registrera vilken gren som laget ska delta i!\n1: Barr\n2:Gymnastik\nAnnan sport som jag inte kan namn på\n");
                    if (CoursePick == 1)
                    {
                        Console.WriteLine("Du har valt Barr!!");
                        //Kör registering av barr i Registercompetition liknande register teams
                    }
                    if (CoursePick == 2)
                    {
                        Console.WriteLine("Du har valt Gymnastik!");
                        //Kör registering av gymnastik i Registercompetition liknande Register teams
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
                if (UserChoice == 2)
                {
                    Console.WriteLine("Registrera poängen som laget fick i grenen!");
                    //Kör registering av registering av poäng i RegisterPoints. Mata in 3 värden, ge ut medelvärdet!

                }
                if (UserChoice > 2)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Finns inget commando på det numret stänger av");
                    Console.ResetColor();
                }
            }
        }

        public static int userInput(string prompt) // För att se vad användaren matar in. /för att det ska tolkas. <- Till menyvalet 
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(prompt);
                    int input = int.Parse(Console.ReadLine());
                    return input;
                }
                catch //Men om man matar in något annat en en siffra
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Error inget nummer angavs\n");
                    Console.ResetColor();
                }
            }
        }
        public static int userInput1(string prompt) // För att se vad användaren matar in. /för att det ska tolkas. <- Till menyvalet 
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(prompt);
                    int input = int.Parse(Console.ReadLine());
                    return input;
                }
                catch //Men om man matar in något annat en en siffra
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Error inget nummer angavs\n");
                    Console.ResetColor();
                }
            }
        }
        public static int coursePick(string prompt) // För att se vad användaren matar in. /för att det ska tolkas. <- Till menyvalet 
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(prompt);
                    int input = int.Parse(Console.ReadLine());
                    return input;
                }
                catch //Men om man matar in något annat en en siffra
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Error inget nummer angavs\n");
                    Console.ResetColor();
                }
            }
        }
    }
}
