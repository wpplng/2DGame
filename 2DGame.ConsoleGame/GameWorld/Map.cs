﻿using _2DGame.ConsoleGame.GameWorld;
using System.Diagnostics;

internal class Map : IMap
{
    private Cell[,] _cells;
    public int Height { get; }
    public int Width { get; }

    public List<Creature> Creatures { get; } = new List<Creature>();

    public Map(int height, int width)
    {
        this.Height = height;
        this.Width = width;

        _cells = new Cell[height, width];

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                _cells[y, x] = new Cell(new Position(y, x));
            }
        }
    }

    public Cell? GetCell(int y, int x)
    {
        return (x < 0 || x >= Width || y < 0 || y >= Height) ? null : _cells[y, x];
    }

    public Cell? GetCell(Position newPosition)
    {
        return GetCell(newPosition.Y, newPosition.X);
    }
}