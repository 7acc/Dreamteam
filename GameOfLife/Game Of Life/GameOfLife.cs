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
        private string _menu = "Welcome to Game Of Life\n\nR) Run the game in defaultmode:\n\nC) Create a custom gamemode:\n\nQ) Quit game:";
        

        public void Run()
        {
            do
            {
                Console.Clear();
                Console.WriteLine(_menu);
                _choice = Console.ReadKey(true);
                switch (_choice.Key)
                {
                    case ConsoleKey.R:
                        var defoult = InitializeDefoult();
                        RunGame(defoult);
                        break;
                    case ConsoleKey.C:
                        var custom = InitializeCustom();
                        RunGame(custom);
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

        public Board InitializeCustom()
        {
            Console.WriteLine("Enter desired hight and width of the playfield.");
            var hight = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());

            Board NewBoard = new Board(hight,width);

            Console.WriteLine("How many cells do you want play with ?");
            var numberOfCells = int.Parse(Console.ReadLine());
            if (numberOfCells >(NewBoard.Hight*NewBoard.Width))
            {
                numberOfCells = NewBoard.Hight*NewBoard.Width;
            }
            NewBoard.FillArray(numberOfCells);
            return NewBoard;

        }
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

                var newGameboard = newCellhandler.DeadOrAlive(game.GetArray());

                game.GameBoard = newGameboard;          
               
            }
        }
        
    }
}
