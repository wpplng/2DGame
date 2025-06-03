﻿


using _2DGame.ConsoleGame;
using _2DGame.ConsoleGame.Extensions;
using System.ComponentModel;

internal class Game
{
    private Map _map = null!;
    private Creature _player = null!;

    public Game()
    {
    }

    internal void Run()
    {
        Init();
        Play();
    }

    private void Play()
    {
        bool gameInProgress = true;
        do
        {
            // Drawmap
            Drawmap();

            // GetCommand
            GetCommand();

            // Act

            // Drawmap

            // Enemyaction

            // Drawmap

            // Console.ReadLine();

        }
        while (gameInProgress);
        {
            
        }
    }

    private void GetCommand()
    {
        var keypressed = ConsoleUI.GetKey();
        switch(keypressed)
        {
            case ConsoleKey.UpArrow:
                Move(Direction.North);
                break;
            case ConsoleKey.DownArrow:
                Move(Direction.South);
                break;
            case ConsoleKey.LeftArrow:
                Move(Direction.West);
                break;
            case ConsoleKey.RightArrow:
                Move(Direction.East);
                break;
        }
    }

    private void Move(Position movement)
    {
        var newPosition = _player.Cell.Position + movement;
        var newCell = _map.GetCell(newPosition);
        if (newCell is not null) _player.Cell = newCell;
    }

    private void Drawmap()
    {
        Console.Clear();

        for (int y = 0; y < _map.Height; y++)
        {
            for (int x = 0; x < _map.Width; x++)
            {
                Cell? cell = _map.GetCell(y, x);
                ArgumentNullException.ThrowIfNull(cell, nameof(cell));

                IDrawable drawable = _map.Creatures.CreatureAt(cell);

                Console.ForegroundColor = drawable.Color;
                Console.Write(drawable.Symbol);
            }
            Console.WriteLine();
        }
        Console.ResetColor();
    }

    private void Init()
    {
        // ToDo: read from config file
        _map = new Map(height: 10,  width: 10);
        Cell? playerCell = _map.GetCell(0, 0);
        _player = new Player(playerCell!);
        _map.Creatures.Add(_player);
    }
}