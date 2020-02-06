using System;
using System.Collections.Generic;

namespace TextmonAdventure
{
    public class Textmon
    {
        Random leveling = new Random();
        public string name { get; set; }
        public int lvl { get; set; }
        public int HP { get; set; }
        public int BaseHP { get; set; }
        public int spd { get; set; }
        public int str { get; set; }
        public int def { get; set; }
        public int xp { get; set; }
        public int Threshold { get; set; }
        public Dictionary<string, int> moves = new Dictionary<string, int>();
        /*public Textmon(int num)
        {
            lvl = num;
            xp = 0;                     This constructor became pointless due to the fact the textmon needs a name
            initializeStats(lvl);
        }*/

        public Textmon(string a, int level)
        {
            name = a;
            lvl = level;
            xp = 0;
            InitializeStats(lvl);
        }

        public void InitializeStats(int lvl)
        {
            HP = 5 * lvl;
            str = 2 * lvl;
            spd = lvl / 2;
            def = lvl;
            Threshold = lvl * 4;
        }

        

        public void TakeDamage(int damage)
        {
            HP -= (damage - def);
        }

        public void Heal()
        {
            HP = BaseHP;
        }

        public void LevelUp()
        {
            if(xp > Threshold)
            {
                Threshold += lvl * 2;
                HP += leveling.Next(1, 6);
                spd += leveling.Next(1, 3);
                def += leveling.Next(1, 4);
                str += leveling.Next(1, 5);
                xp = 0;
                BaseHP = HP;
            }
            else
            {
                Console.WriteLine($"{name} isn't ready to level up!");
            }
        }
    }
}
