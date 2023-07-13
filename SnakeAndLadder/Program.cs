using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
           Operations operations = new Operations();
            operations.DieRoll();
            operations.Game();
        }
    }
}
