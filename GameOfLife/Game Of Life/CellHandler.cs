using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Life
{
    class CellHandler
    {
        enum State { Dead = 0, Alive = 1 };

        Random rnd = new Random();
        public int GenerateRandomNumber()
        {
            int randomNumber = rnd.Next(0, 2);
            return randomNumber;
        }
        public int GenereateRandomPosition(int from, int to)
        {
            int randomPosition = rnd.Next(from, to);
            return randomPosition;
        }
        public int CountNeighbors(int[,] array, int y, int x)
        {
            int neighborCount = 0;

            if (y != 0)
                if (array[y - 1, x] == (int)State.Alive)
                    neighborCount++;
            if (y != array.GetLength(0) - 1)
                if (array[y + 1, x] == (int)State.Alive)
                    neighborCount++;
            if (x != 0)
                if (array[y, x - 1] == (int)State.Alive)
                    neighborCount++;
            if (x != array.GetLength(1) - 1)
                if (array[y, x + 1] == (int)State.Alive)
                    neighborCount++;

            if (y != 0 && x != 0)
                if (array[y - 1, x - 1] == (int)State.Alive)
                    neighborCount++;
            if (y != array.GetLength(0) - 1 && x != 0)
                if (array[y + 1, x - 1] == (int)State.Alive)
                    neighborCount++;

            if (y != 0 && x != array.GetLength(1) - 1)
                if (array[y - 1, x + 1] == (int)State.Alive)
                    neighborCount++;
            if (y != array.GetLength(0) - 1 && x != array.GetLength(1) - 1)
                if (array[y + 1, x + 1] == (int)State.Alive)
                    neighborCount++;

            return neighborCount;
        }

        public int[,] DeadOrAlive(int[,] array)
        {
            var tempArray = new int[array.GetLength(0), array.GetLength(1)];



            //for (int y = 0; y < array.GetLength(0); y++)
            //{
            //    for (int x = 0; x < array.GetLength(1); x++)
            //    {
            //        var count = CountNeighbors(array,y, x);

            //        if (array[y, x] == (int)State.Dead && count == 3)
            //            tempArray[y, x] = (int)State.Alive;

            //        else if (array[y, x] == (int)State.Alive && count == 2)
            //            tempArray[y, x] = (int)State.Alive;

            //        else if (array[y, x] == (int)State.Alive && count == 3)
            //            tempArray[y, x] = (int)State.Alive;

            //        else if (array[y, x] == (int)State.Alive && count < 2)
            //            tempArray[y, x] = (int)State.Dead;

            //        else if (array[y, x] == (int)State.Alive && count > 3)
            //            tempArray[y, x] = (int)State.Dead;
            //    }
            //}

            for (int y = 0; y < array.GetLength(0); y++)

            {

                for (int x = 0; x < array.GetLength(1); x++)

                {
                    var count = CountNeighbors(array,y, x);

                    if (array[y, x] == (int)State.Dead && count == 3)
                        tempArray[y, x] = 1;

                    if (array[y, x] == (int)State.Alive && (count == 2 || count == 3))
                        tempArray[y, x] = (int)State.Alive;


                }

            }
            return tempArray;
        }
    }
}
