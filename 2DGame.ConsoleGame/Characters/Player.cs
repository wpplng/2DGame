using _2DGame.ConsoleGame;
using _2DGame.LimitedList;

internal class Player : Creature
{
    public LimitedList<Item> BackPack { get; }
    public Player(Cell cell) : base(cell, "P ") 
    {
        Color = ConsoleColor.White;
        BackPack = new LimitedList<Item>(3);
    }
}