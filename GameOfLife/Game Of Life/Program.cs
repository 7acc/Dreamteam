using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WindowHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth;          
            GameOfLife newGame = new GameOfLife();

            newGame.Run();
        }
    }
}
