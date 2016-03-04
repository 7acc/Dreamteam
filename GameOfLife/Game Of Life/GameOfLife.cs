using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game_Of_Life
{
    class GameOfLife
    {
        CellHandler newCellhandler = new CellHandler();
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
                    case ConsoleKey.A:
                        var defoult = InitializeDefoult();
                        RunGame(defoult);
                        break;
                    case ConsoleKey.B:

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

        //public Board InitializeCustom()
        //{
            
        //    Board NewBoard = new Board();
            
        //}
        public Board InitializeDefoult()
        {
            Board DefoultBoard = new Board(20, 40);
            DefoultBoard.FillArray(400);
            return DefoultBoard;
        }
        public void RunGame(Board game)
        {
            while (true)
            {
                Console.Clear();
                var cellGeneration = game.PrintArray();
                Console.WriteLine(cellGeneration);

                Thread.Sleep(300);

                var gameboard = newCellhandler.DeadOrAlive(game.GameBoard);

                game.GameBoard = gameboard;              
               
            }
        }
    }
}
