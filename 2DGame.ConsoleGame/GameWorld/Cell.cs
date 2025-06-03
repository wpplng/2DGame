﻿using _2DGame.ConsoleGame.GameWorld;

internal class Cell : IDrawable
{
    public string Symbol => ". ";
    public ConsoleColor Color { get; }
    public Position Position { get; }

    public Cell(Position position)
    {
        Color = ConsoleColor.Red;
        Position = position;
    }
}