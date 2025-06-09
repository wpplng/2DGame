using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGame.ConsoleGame.Extensions;

internal static class MapExtensions
{
    public static IDrawable? CreatureAt(this List<Creature> creatures, Cell cell)
    {
        //IDrawable? result = null;

        //foreach (Creature creature in creatures)
        //{
        //    if (creature.Cell == cell)
        //    {
        //        result = creature;
        //        break;
        //    }
        //}

        //return result;

        // Using LINQ to find the first creature at the specified cell
        // kan använda c istället för creature i lambda uttrycket
        return creatures.FirstOrDefault(creature => creature.Cell == cell);
    }
}