using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcomeScreen();
            DisplayMenu();
            DisplayClosingScreen();
        }

        static void DisplayMenu()
        {
            bool exitMenu = false;
            SeaMonster Nessy = InitializeSeaMonster();
            SpaceMonster Jaal = InitializeSpaceMonsters();


            do
            {
                DisplayHeader("Menu");
                Console.WriteLine("A) Display Monsters");
                Console.WriteLine("B) Fight Jaal");
                Console.WriteLine("C) Fight Nessy");
                Console.WriteLine("Q) Exit");
                Console.WriteLine("Enter Choice");
                string userChoice = Console.ReadLine().ToUpper();

                switch (userChoice)
                {
                    case "A":
                        DisplayMonsterInfoScreen(Nessy, Jaal);
                        break;
                    case "B":
                        DisplayFightingSpaceMonster(Jaal);
                        break;
                    case "C":
                        DisplayFightingSeaMonster(Nessy);
                        break;
                    case "Q":
                        DisplayClosingScreen();
                        exitMenu = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid choice");
                        DisplayContinuePrompt();
                        break;
                }
            } while (!exitMenu);
        }

        private static void DisplayFightingSeaMonster(SeaMonster seaMonster)
        {
            DisplayHeader("Fighting Nessy");

            Console.WriteLine($"You attack {seaMonster.Name} and they {seaMonster.MonsterBattleResponse()}");

            DisplayContinuePrompt();
        }

        private static void DisplayFightingSpaceMonster(SpaceMonster spaceMonster)
        {
            DisplayHeader("Fighting Jaal");

            Console.WriteLine($"You attack {spaceMonster.Name} and they {spaceMonster.MonsterBattleResponse()}");

            DisplayContinuePrompt();
        }

        static void DisplayMonsterInfoScreen(SeaMonster seaMonster, SpaceMonster spaceMonster)
        {
            DisplayHeader("Monster Information");

            DisplaySeaMonster(seaMonster);
            Console.WriteLine();
            DispalySpaceMonster(spaceMonster);



            DisplayContinuePrompt();
        }

         static void DispalySpaceMonster(SpaceMonster spaceMonster)
        {
            Console.WriteLine($"Id: {spaceMonster.ID}");
            Console.WriteLine($"Name: {spaceMonster.Name}");
            Console.WriteLine($"Owns a Spaceship: {(spaceMonster.HasSpaceShip ? "Yes" : "No" )}");
            Console.WriteLine($"Age: {spaceMonster.Age}");
            Console.WriteLine($"Active: {(spaceMonster.IsActive ? "Yes" : "No")}");
            Console.WriteLine($"Happiness Status:{spaceMonster.IsHappy()}");
            Console.WriteLine($"Home: {spaceMonster.HomeGalaxy} ");
            Console.WriteLine($"Fighting Style: {spaceMonster.FightingStyle}");
            Console.WriteLine($"{spaceMonster.Greeting()}");
            Console.WriteLine($"{spaceMonster.Background()}");
            Console.WriteLine($"Fights Won: {spaceMonster.FightsWon()}");
            Console.WriteLine($"High Value Target: {spaceMonster.isHVT}");
            
           
        }

        static void DisplaySeaMonster(SeaMonster seaMonster)
        {
            Console.WriteLine($"Id: {seaMonster.ID}");
            Console.WriteLine($"Name: {seaMonster.Name}");
            Console.WriteLine($"Age: {seaMonster.Age}");
            Console.WriteLine($"Gills: {seaMonster.HasGills}");
            Console.WriteLine($"Tentecals: {seaMonster.HasTentecals}");
            Console.WriteLine($"Active: {(seaMonster.IsActive ? "Yes" : "No")}");
            Console.WriteLine($"Happiness Status: {seaMonster.IsHappy()}");
            Console.WriteLine($"Home: {seaMonster.SeaName}");
            Console.WriteLine($"Fighting Style: {seaMonster.FightingStyle}");
            Console.WriteLine($"{seaMonster.Greeting()}");
            Console.WriteLine($"{seaMonster.Background()}");
            Console.WriteLine($"Fights Won: {seaMonster.FightsWon()}");
            Console.WriteLine($"High Value Target: {seaMonster.isHVT}");
            
        }

        static void DisplayWelcomeScreen()
        {
            Console.Clear();
            Console.WriteLine("\t\tWelcome to Monster Battles!");
            DisplayContinuePrompt();
        }

        static void DisplayClosingScreen()
        {
            Console.Clear();
            Console.WriteLine("\t\tThank You For using Monster Battles!");
            DisplayContinuePrompt();
        }

        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        static void DisplayHeader(string headText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(headText);
            Console.WriteLine();
        }
        static SeaMonster InitializeSeaMonster()
        {
            return new SeaMonster()
            {
                ID = 344,
                Name = "Nessy",
                HasGills = false,
                HasTentecals = false,
                Age = 556,
                IsActive = true,
                SeaName = "Loch Ness",
                FightingStyle = "Melee",
                Weight = 1000,
                Size = "Large",
                isHVT = false
                

                

            };

        }
        static SpaceMonster InitializeSpaceMonsters()
        {
            return new SpaceMonster()
            {
                ID = 369,
                Name = "Jaal",
                HasSpaceShip = true,
                Age = 165,
                IsActive = true,
                HomeGalaxy = "Andromeda",
                FightingStyle = "Ranged",
                Weight = 100,
                Size = "Small",
                isHVT = true

                
            };
        }
    }
   
}
