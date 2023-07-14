using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operations1= new Operations();
            Operations operations2 = new Operations();

            String player1 = "";
            String player2 = "";

            while (!operations1.GetWon() || !operations2.GetWon())
            {
                player1 += operations1.Game()+" | ";//99
                player2 += operations2.Game()+" | ";//99
            }

            Console.WriteLine("position of player 1");
            Console.WriteLine(player1);
            Console.WriteLine("position of player 2");
            Console.WriteLine(player2);

            if (operations1.GetWon())
            {
                Console.WriteLine("player 1 won and total number of dice roll is "+ operations1.GetCount());
            }
            else if (operations2.GetWon())
            {
                Console.WriteLine("player 2 won and the total number of dice roll is "+ operations2.GetCount());
            }
        }
    }
}
