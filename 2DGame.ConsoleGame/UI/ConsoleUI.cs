﻿

using _2DGame.ConsoleGame.Extensions;
using _2DGame.LimitedList;

internal class ConsoleUI
{
    private static MessageLog<string> _messageLog = new(6);

    internal static void AddMessage(string message) => _messageLog.Add(message);

    // hade egentligen kunnat loopa och skriva ut loggen direkt
    internal static void PrintLog()
    {
        _messageLog.Print(m => Console.WriteLine(m + new string(' ', Console.WindowWidth - m.Length)));
    }
    internal static void Draw(IMap map)
    {
        for (int y = 0; y < map.Height; y++)
        {
            for (int x = 0; x < map.Width; x++)
            {
                Cell? cell = map.GetCell(y, x);
                ArgumentNullException.ThrowIfNull(cell, nameof(cell));

                IDrawable drawable = map.Creatures.CreatureAt(cell) ?? cell.Items.FirstOrDefault() as IDrawable ?? cell;

                Console.ForegroundColor = drawable.Color;
                Console.Write(drawable.Symbol);
            }
            Console.WriteLine();
        }
        Console.ResetColor();
    }

    internal static ConsoleKey GetKey() => Console.ReadKey(intercept: true).Key;

    internal static void Clear()
    {
        Console.CursorVisible = false;
        Console.SetCursorPosition(0, 0);
    }

    internal static void PrintStats(string stats)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(stats);
        Console.ForegroundColor = ConsoleColor.White;

    }
}