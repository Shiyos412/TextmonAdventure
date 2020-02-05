using System;
namespace TextmonAdventure
{
    public static class Story
    {
        public static TextTrainer main = new TextTrainer("temp");
        public static TextTrainer rival = new TextTrainer("temp");
        public static string name { get; set; }
        public static string rivalName { get; set; }
        public static void IntroSequence()
        {
            string title = @" _________                _   ____    ____                  
|  _   _  |              / |_|_   \  /   _|                 
|_/ | | \_|.---.  _   __`| |-' |   \/   |   .--.   _ .--.   
    | |   / /__\\[ \ [  ]| |   | |\  /| | / .'`\ \[ `.-. |  
   _| |_  | \__., > '  < | |, _| |_\/_| |_| \__. | | | | |  
  |_____|  '.__.'[__]`\_]\__/|_____||_____|'.__.' [___||__] 
                                                            ";
            Console.WriteLine(title);
            string s = "Press Any Key to Continue...";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            Console.ReadKey();
            Console.Clear();
            s = "Welcome to the World of Textmon\nIn this world, we use Textmon to battle competitively!";
            Console.WriteLine(s);
            System.Threading.Thread.Sleep(500);
            s = "You're about to embark on a grand adventure!\nYou will be battling and traveling to many new places and meeting many new faces";
            Console.WriteLine("\n");
            Console.WriteLine(s);
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("\n");
            s = "What is your name?";
            Console.WriteLine(s);
            name = Console.ReadLine();
            main.trainerName = name;
            System.Threading.Thread.Sleep(500);
            s = "You have a childhood friend, what was their name..?";
            Console.WriteLine("\n");
            Console.WriteLine(s);
            rivalName = Console.ReadLine();
            rival.trainerName = rivalName;
            s = $"Okay {main.trainerName}, lets begin your adventure!";
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("\n");
            Console.WriteLine(s);
        }
        public static void IlexOne()
        {
            Console.Clear();
            Console.WriteLine($"Prof. Ilex: Hey, {main.trainerName}! I need your help with an experiment, follow me back to the lab.");
            Console.WriteLine("\n");
            Console.WriteLine($"Prof Ilex: As you know, we study pokemon here, and seeing as you're coming of age in this world" +
                $" I spoke with your mother and have decided to give you your own TextMon as well as the TextDex so you can help" +
                $" me out with researching every kind of TextMon there is!");
            Console.WriteLine("\n");
            Console.WriteLine($"Go ahead! Pick one {main.trainerName}!");
            Console.WriteLine("You see the Turtle TextMon Squirtle, the Fiery TextMon Charmander and the Leafy TextMon Bulbasaur");
            Console.WriteLine("Which one will you pick?");
            while (true)
            {
                string choice = Console.ReadLine();
                switch (choice.ToLower())
                {
                    case ("squirtle"):
                        Textmon Squirtle = new Textmon("Squirtle", 5);
                        main.team.Add(Squirtle);
                        break;
                    case ("charmander"):
                        Textmon Charmander = new Textmon("Charmander", 5);
                        main.team.Add(Charmander);
                        break;
                    case ("bulbasaur"):
                        Textmon Bulbasaur = new Textmon("Bulbasaur", 5);
                        main.team.Add(Bulbasaur);
                        break;
                    default:
                        Console.WriteLine("Try again!");
                        break;
                }
                break;
            }
            Console.WriteLine($"\nCongrats {main.trainerName}! You got a {main.team[0].name}!");
            
        }
    }
}
