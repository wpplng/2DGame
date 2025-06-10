using _2DGame.ConsoleGame;
using _2DGame.ConsoleGame.Extensions;
using _2DGame.ConsoleGame.GameWorld;
using System;
using System.ComponentModel;

internal class Game
{
    private Map _map = null!;
    private Player _player = null!;
    private Dictionary<ConsoleKey, Action> actionmeny = null!;

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
            //case ConsoleKey.P:
            //    PickUp();
            //    break;
            //case ConsoleKey.I:
            //    Inventory();
            //    break;
        }
        if (actionmeny.ContainsKey(keypressed))
        {
            actionmeny[keypressed].Invoke();
        }
    }

    private void Inventory()
    {
        for (int i = 0; i < _player.BackPack.Count; i++)
        {
            ConsoleUI.AddMessage($"{i + 1}: {_player.BackPack[i]}");
        }
    }

    private void PickUp()
    {
        if(_player.BackPack.IsFull)
        {
            ConsoleUI.AddMessage("Backpack is full, cannot pick up item.");
            return;
        }
        var items = _player.Cell.Items;
        var item = items.FirstOrDefault();
        if (item is null) return;
        if (_player.BackPack.Add(item))
        {
            ConsoleUI.AddMessage($"Player picked up {item}.");
            items.Remove(item);
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
        ConsoleUI.Clear();
        ConsoleUI.Draw(_map);
        ConsoleUI.PrintStats($"Health: {_player.Health}");
        ConsoleUI.PrintLog();
    }

    private void Init()
    {
        CreateActionMeny();
        // ToDo: read from config file
        _map = new Map(height: 10, width: 10);
        Cell? playerCell = _map.GetCell(0, 0);
        _player = new Player(playerCell!);
        _map.Creatures.Add(_player);

        _map.GetCell(2, 6)?.Items.Add(Item.Coin());
        _map.GetCell(3, 3)?.Items.Add(Item.Stone());
        _map.GetCell(1, 4)?.Items.Add(Item.Coin());
        _map.GetCell(2, 2)?.Items.Add(Item.Stone());

    }

        private void CreateActionMeny()
        {
            actionmeny = new Dictionary<ConsoleKey, Action>()
            {
                { ConsoleKey.P, PickUp    },
                { ConsoleKey.I, Inventory }
            };
        }
    
}