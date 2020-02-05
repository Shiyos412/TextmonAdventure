using System;
namespace TextmonAdventure
{
    public static class Story
    {
        private static string name;
        private static string rivalName;
        public static string getName()
        {
            return name;
        }
        public static void IntroSequence()
        {
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
            System.Threading.Thread.Sleep(500);
            s = "You have a childhood friend, what was their name..?";
            Console.WriteLine("\n");
            Console.WriteLine(s);
            rivalName = Console.ReadLine();
            s = $"Okay {name}, lets begin your adventure!";
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("\n");
            Console.WriteLine(s);
        }
        public static void IlexOne()
        {

        }
    }
}
