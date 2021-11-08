using System;

namespace HanoiTowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(5);

            Console.WriteLine(game);

            game.Resolve();
        }
    }
}
