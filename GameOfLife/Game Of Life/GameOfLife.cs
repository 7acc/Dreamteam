using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Life
{
    class GameOfLife
    {
        private ConsoleKeyInfo choice;
        private bool loop = true;
        private string menu = "";
        public void run()
        {
            do
            {
                Console.Clear();
                choice = Console.ReadKey(true);
                switch (choice.Key)
                {
                    case ConsoleKey.A:
                        break;
                    case ConsoleKey.B:
                        break;
                    case ConsoleKey.Q:
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("invalid input, try again!");
                        break;
                }
            } while (loop);
        }
    }
}
