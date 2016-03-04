using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Life
{
    class Board
    {
        private int _hight;
        private int _width;

        private int[,] gameBoard;
        public int MyProperty { get; set; }
        public int Hight
        {
            set
            {
                if (value > 0)
                    this._hight = value;
            }
            get { return _hight; }
        }
        public int Width
        {
            set
            {
                if (value > 0)
                    this._hight = value;
            }
            get { return _hight; }
        }


        public Board(int hight, int widht)
        {
            this._hight = hight;
            this._hight = widht;

            gameBoard = new int[hight, widht];
        }
        public void FillArray(int amount)
        {
            for (int y = 0; y < amount; y++)
            {
                int row = rnd.Next(0, array.GetLength(0));
                int col = rnd.Next(0, array.GetLength(1));

                if (array[row, col] == (int)state.alive)
                {
                    y--;

                }
                else
                {
                    array[row, col] = (int)state.alive;
                }
            }
        }

        public void printArray()
        {
            for (int y = 0; y < gameBoard.GetLength(0); y++)
            {
                for (int x = 0; x <= gameBoard.GetLength(1); x++)
                {
                    if (x == gameBoard.GetLength(1))
                    {
                        Console.Write("\n");
                    }
                    //else if (gameBoard[y, x] == 10)
                    //{
                    //    Console.Write("O");
                    //}
                    else if (gameBoard[y, x] == 1)
                    {
                        Console.Write("██");
                    }
                    else if (gameBoard[y, x] == 0)
                    {
                        Console.Write("  ");
                    }
                }
            }
        }
        public string PrintArray()
        {
            StringBuilder nextState = new StringBuilder();

            for (int y = 0; y < gameBoard.GetLength(0); y++)
            {
                for (int x = 0; x <= gameBoard.GetLength(1); x++)
                {
                    if (x == gameBoard.GetLength(1))
                    {
                        nextState.Append("\n");
                    }
                    //else if (gameBoard[y, x] == 10)
                    //{
                    //    Console.Write("O");
                    //}
                    else if (gameBoard[y, x] == 1)
                    {
                        nextState.Append("██");
                    }
                    else if (gameBoard[y, x] == 0)
                    {
                        nextState.Append("  ");

                    }
                }
            }
            return nextState.ToString();
        }
    }
}
