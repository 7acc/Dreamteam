using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Life
{
    class GameOfLife
    {
        private ConsoleKeyInfo _choice;
        private bool _loop = true;
        private string _menu = "";
        public void Run()
        {
            do
            {
                Console.Clear();
                _choice = Console.ReadKey(true);
                switch (_choice.Key)
                {
                    case ConsoleKey.R:
                        
                        break;
                    case ConsoleKey.C:
                        break;
                    case ConsoleKey.Q:
                        _loop = false;
                        break;
                    default:
                        Console.WriteLine("invalid input, try again!");
                        break;
                }
            } while (_loop);
        }
    }
}
