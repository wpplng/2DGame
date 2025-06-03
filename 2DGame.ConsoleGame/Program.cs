

using _2DGame.LimitedList;

var lm = new LimitedList<Creature>(10);
var li = new List<int>(10);

var game = new Game();
game.Run();

Console.WriteLine("Game has ended. Press any key to exit.");
