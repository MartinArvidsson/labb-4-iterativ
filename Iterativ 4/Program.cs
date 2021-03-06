﻿using System;
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
                AddTeamTest.Run();
                RegisterCompTest.Run();
                RegisterPointsTest.Run();

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
            login login = new login(); 
            AddTeam addTeam = new AddTeam(); 
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
                    if (addTeam.TeamExist != false)
                    {
                        
                        UserChoice = userInput1("Väj ett alternativ:\n1:Registrera lag på gren\n2:Ge poäng!");
                        Console.Clear();
                    }

                }
                
                
                
                if (UserChoice == 1 && addTeam.TeamExist != false)
                {
                    Console.Clear();
                    CoursePick = coursePick("Registrera vilken gren som laget ska delta i!\n1: Barr\n2:Gymnastik\n");
                    if (CoursePick == 1)
                    {
                        Console.WriteLine("Du har valt Barr!!");
                        register.registerBarr();
                        //Kör registering av barr i Registercompetition liknande register teams
                        if (register.competitionExist != false)
                        {

                            UserChoice = userInput1("Väj ett alternativ:\n2:Ge poäng!");
                            Console.Clear();
                        }
                    }
                    if (CoursePick == 2)
                    {
                        Console.WriteLine("Du har valt Gymnastik!");
                        register.registerGymnastic();
                        //Kör registering av gymnastik i Registercompetition liknande Register teams
                        if (register.competitionExist != false)
                        {

                            UserChoice = userInput1("Väj ett alternativ:\n2:Ge poäng!");
                            Console.Clear();
                        }
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
                else
                {
                    Console.WriteLine("Kan inte utföra kommandot, antingen saknas ett lag eller är ingen gren anmäld");
                }



                if (UserChoice == 2 && addTeam.TeamExist != false && register.competitionExist != false)
                {
                    //Kör registering av registering av poäng i RegisterPoints. Mata in 3 värden, ge ut medelvärdet!
                    points.registerPoints();

                }
                if (UserChoice > 2 || UserChoice < 2)
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
                    Console.WriteLine("Error inget nummer angavs");
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
                    Console.WriteLine("Error inget nummer angavs");
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
                    Console.WriteLine("Error inget nummer angavs");
                    Console.ResetColor();
                }
            }
        }
    }
}
