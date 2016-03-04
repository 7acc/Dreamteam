using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Life
{
    class Board
    {
        private int hight;
        private int width;

        private int[,] gameBoard;
        public int MyProperty { get; set; }
        public int Hight
        {
            set
            {
                if (value > 0)
                    this.hight = value;
            }
            get { return hight; }
        }
        public int Width
        {
            set
            {
                if (value > 0)
                    this.hight = value;
            }
            get { return hight; }
        }


        public Board(int hight, int widht)
        {
            this.hight = hight;
            this.hight = widht;

            gameBoard = new int[hight, widht];
        }
        public void FillArray(int amount)
        {
            for (int y = 0; y < amount; y++)
            {
                int row = CellHandler.GenereateRandomPosition(0, gameBoard.GetLength(0));
                int col = CellHandler.GenereateRandomPosition(0, gameBoard.GetLength(1));

                if (gameBoard[row, col] == 1)
                {
                    y--;

                }
                else
                {
                    gameBoard[row, col] = 1;
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
            StringBuilder NextState = new StringBuilder();

            for (int y = 0; y < gameBoard.GetLength(0); y++)
            {
                for (int x = 0; x <= gameBoard.GetLength(1); x++)
                {
                    if (x == gameBoard.GetLength(1))
                    {
                        NextState.Append("\n");
                    }
                    //else if (gameBoard[y, x] == 10)
                    //{
                    //    Console.Write("O");
                    //}
                    else if (gameBoard[y, x] == 1)
                    {
                        NextState.Append("██");
                    }
                    else if (gameBoard[y, x] == 0)
                    {
                        NextState.Append("  ");

                    }
                }
            }
            return NextState.ToString();
        }
    }
}
