using System.Diagnostics.CodeAnalysis;

internal abstract class Creature : IDrawable
{
    private Cell _cell;
    public string Symbol { get; }
    public ConsoleColor Color { get; protected set; } = ConsoleColor.Green;

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
    public Creature(Cell cell, string symbol)
    {
        if (string.IsNullOrWhiteSpace(symbol))
        {
            throw new ArgumentException("Symbol cannot be null or whitespace.", nameof(symbol));
        }
        Cell = cell; // ?? throw new ArgumentNullException(nameof(cell));
        Symbol = symbol;

    }
}
