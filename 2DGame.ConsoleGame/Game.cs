


internal class Game
{
    private Map _map = null!;
    private Player _player = null!;

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

            // Act

            // Drawmap

            // Enemyaction

            // Drawmap

            Console.ReadLine();

        }
        while (gameInProgress);
        {
            
        }
    }

    private void Drawmap()
    {
        Console.Clear();

        for (int y = 0; y < _map.Height; y++)
        {
            for (int x = 0; x < _map.Width; x++)
            {
                // ToDo: handel null cells
                Cell? cell = _map.GetCell(y, x);
                Console.ForegroundColor = cell.Color;
                Console.Write(cell.Symbol);
            }
            Console.WriteLine();
        }
        Console.ResetColor();
    }

    private void Init()
    {
        // ToDo: read from config file
        _map = new Map(height: 10,  width: 10);
        _player = new Player();
    }
}