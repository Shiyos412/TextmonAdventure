using System;
namespace TextmonAdventure
{
    public class Battles
    {
        Random rand = new Random();
        public Textmon Opponent { get; set; }
        public Textmon Friendly { get; set; }
        public static string[] route1 = { "Pidgey", "Caterpie", "Ratatta" };
        public static string[] viridianC = { "Mankey, Nidoran, Spearow" };
        public static string[] viridianF = {"Caterpie", "Weedle", "Pikachu" };
        public Battles(Textmon friend, string area)
        {
            switch (area)
            {
                case ("route1"):
                    Opponent = new Textmon(route1[rand.Next(0, 2)], rand.Next(2, 4));
                    break;
                case ("Viridian City"):
                    Opponent = new Textmon(viridianC[rand.Next(0, 2)], rand.Next(2, 5));
                    break;
                case ("Viridian Forest"):
                    Opponent = new Textmon(viridianF[rand.Next(0, 2)], rand.Next(3, 7));
                    break;
                case ("Pewter City"):
                    Opponent = new Textmon("Onix", 13);
                    break;
            }
            Console.WriteLine($"Let the battle begin between {friend.name} and {Opponent}!");   
        }

        public void Battling()
        {
            while(Friendly.HP > 0 && Opponent.HP > 0)
            {
                if(Friendly.spd >= Opponent.spd)
                {
                    Console.WriteLine("You go first! What will you do?");
                    Console.WriteLine("1. Attack\n2. Run\n 3. Item");
                    string s = Console.ReadLine();
                }
            }
        }
    }
}
