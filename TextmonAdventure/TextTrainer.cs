using System;
using System.Collections.Generic;

namespace TextmonAdventure
{
    public class TextTrainer
    {
        public string trainerName { get; set; }
        public List<Textmon> team = new List<Textmon>();
        public TextTrainer(string name)
        {
            trainerName = name;
        }

        
    }
}
