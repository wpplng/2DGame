using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGame.ConsoleGame.Characters
{
    internal class Orc : Creature
    {
        public Orc(Cell cell) : base(cell, "O ", 80, 30)
        {
            Color = ConsoleColor.DarkGreen;
        }
    }
}
