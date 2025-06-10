﻿using System.Diagnostics.CodeAnalysis;

internal abstract class Creature : IDrawable
{
    private Cell _cell;
    private int _health;
    public string Symbol { get; }
    public ConsoleColor Color { get; protected set; } = ConsoleColor.Green;
    public int MaxHealth { get; }
    public int Damage { get; protected set; }
    public bool isDead => _health <= 0;
    public int Health 
    { 
        get => _health;
        private set => _health = value >= MaxHealth ? MaxHealth : value;
    }

    public Cell Cell 
    {
        get => _cell;
        [MemberNotNull(nameof(_cell))] // Ensures _cell is not null when set
        set
        {
            ArgumentNullException.ThrowIfNull(value, nameof(value));
            _cell = value;
        }
    }
    public Creature(Cell cell, string symbol, int damage = 50, int maxHealth = 50)
    {
        if (string.IsNullOrWhiteSpace(symbol))
        {
            throw new ArgumentException("Symbol cannot be null or whitespace.", nameof(symbol));
        }
        Cell = cell; // ?? throw new ArgumentNullException(nameof(cell));
        Symbol = symbol;
        Damage = damage;
        MaxHealth = maxHealth;
        Health = maxHealth; // Initialize health to max health
    }
}
