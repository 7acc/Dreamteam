﻿using System;
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
        CellHandler cellHandler;

        public int[,] GameBoard
        {
            set { this.gameBoard = value; }
        }
           
          
          

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
            this._width = widht;

            gameBoard = new int[hight, widht];
            cellHandler = new CellHandler();
        }

        public Board()
        {
            
        }
        
        public void FillArray(int amount)
        {
            for (int y = 0; y < amount; y++)
            {
                int row = cellHandler.GenereateRandomPosition(0, gameBoard.GetLength(0));
                int col = cellHandler.GenereateRandomPosition(0, gameBoard.GetLength(1));

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

        public int[,] GetArray()
        {
            return gameBoard;
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
