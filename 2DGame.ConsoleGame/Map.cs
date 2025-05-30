﻿using System.Diagnostics;

internal class Map
{
    private Cell[,] _cells;
    public int Height { get; }
    public int Width { get; }

    public Map(int height, int width)
    {
        this.Height = height;
        this.Width = width;

        _cells = new Cell[height, width];

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                _cells[y, x] = new Cell();
            }
        }
    }

    internal Cell GetCell(int y, int x)
    {
        try
        {
            return _cells[y, x];
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            return null!;
        }
    }
}