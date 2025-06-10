using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGame.ConsoleGame.Characters
{
    internal class Goblin : Creature
    {
        public Goblin(Cell cell) : base(cell, "G ", 20, 20)
        {
            Color = ConsoleColor.DarkBlue;
        }
    }
}
