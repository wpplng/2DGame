using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGame.ConsoleGame
{
    internal class Direction
    {
        public static Position North => new Position(-1, 0);
        public static Position South => new Position(1, 0);
        public static Position West => new Position(0, -1);
        public static Position East => new Position(0, 1);
    }
}
