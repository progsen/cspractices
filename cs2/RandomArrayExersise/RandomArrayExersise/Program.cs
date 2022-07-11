using System;

namespace RandomArrayExersise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Best game 8 ball");
            Game[] gameCandidates = new Game[] {
                new Game(){ name="Demon's souls"},
                new Game(){ name="Super metroid"},
                new Game(){ name="A link to the past"},
                new Game(){ name="Mario 64"},
                new Game(){ name="Tetris"}
            };

            Console.WriteLine("These are our best game candidates:");
            //print alle candidates uit met console.writeline
            ????

            Console.WriteLine("The winner is:");

            Random rand = new Random();

            //random een getal van 0 tot de length van gamecandidates
            int gamePick = rand.????;

            Game winningGame= gameCandidates[???];//pak de goede
            string winner = winningGame.name;

            Console.WriteLine(winner);

            Console.ReadLine();
        }

    }
}
