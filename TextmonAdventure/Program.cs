using System;
using System.Threading;



//Comments here TODO
namespace TextmonAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            //These are not supported on Mac, but I would like for the game to play in fullscreen or atleast max size
            //Console.WindowWidth = Console.LargestWindowWidth;
            //Console.WindowHeight = Console.LargestWindowHeight;
            Console.Title = "Textmon Adventure Ver .01";
            Story.IntroSequence();
            Story.IlexOne();
            Console.ReadLine();
        }
    }
}
