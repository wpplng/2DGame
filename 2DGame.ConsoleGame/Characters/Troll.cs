using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGame.ConsoleGame.Characters
{
    internal class Troll : Creature
    {
        public Troll(Cell cell) : base(cell, "T ", 60, 60)
        {
            Color = ConsoleColor.DarkGreen;
        }
    }
}
