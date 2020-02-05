using System;

namespace TextmonAdventure
{
    public class Textmon
    {
        Random leveling = new Random();
        public string name { get; set; }
        public int lvl { get; set; }
        public int HP { get; set; }
        public int spd { get; set; }
        public int str { get; set; }
        public int def { get; set; }
        public int xp { get; set; }
        public int threshold { get; set; }
        public Textmon(int num)
        {
            lvl = num;
            xp = 0;
            initializeStats(lvl);
        }

        public Textmon(string a, int lvl)
        {
            name = a;
            this.lvl = lvl;
            this.xp = 0;
            initializeStats(this.lvl);
        }

        private void initializeStats(int lvl)
        {
            HP = 5 * lvl;
            str = 2 * lvl;
            spd = lvl / 2;
            def = lvl;
        }

        private void levelUp()
        {
            if(xp > threshold)
            {
                threshold += this.lvl;
                HP += leveling.Next(1, 6);
                spd += leveling.Next(1, 3);
                def += leveling.Next(1, 4);
                str += leveling.Next(1, 5);
                xp = 0;
            }
            else
            {
                Console.WriteLine($"{name} isn't ready to level up!");
            }
        }
    }
}
