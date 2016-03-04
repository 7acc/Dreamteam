using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Life
{
    class CellHandler
    {
        enum state { dead = 0, alive = 1 };

        Random rnd = new Random();
        public int GenerateRandomNumber()
        {
            int randomNumber = rnd.Next(0, 2);
            return randomNumber;
        }
        public int CountNeighbors(int[,] array, int y, int x)
        {
            int neighborCount = 0;

            if (y != 0)
                if (array[y - 1, x] == (int)state.alive)
                    neighborCount++;
            if (y != array.GetLength(0) - 1)
                if (array[y + 1, x] == (int)state.alive)
                    neighborCount++;
            if (x != 0)
                if (array[y, x - 1] == (int)state.alive)
                    neighborCount++;
            if (x != array.GetLength(1) - 1)
                if (array[y, x + 1] == (int)state.alive)
                    neighborCount++;

            if (y != 0 && x != 0)
                if (array[y - 1, x - 1] == (int)state.alive)
                    neighborCount++;
            if (y != array.GetLength(0) - 1 && x != 0)
                if (array[y + 1, x - 1] == (int)state.alive)
                    neighborCount++;

            if (y != 0 && x != array.GetLength(1) - 1)
                if (array[y - 1, x + 1] == (int)state.alive)
                    neighborCount++;
            if (y != array.GetLength(0) - 1 && x != array.GetLength(1) - 1)
                if (array[y + 1, x + 1] == (int)state.alive)
                    neighborCount++;

            return neighborCount;
        }

        public int[,] DeadOrAlive(int[,] array)
        {
            var tempArray = new int[35, 70];



            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    var count = CountNeighbors(array,y, x);

                    if (array[y, x] == (int)state.dead && count == 3)
                        tempArray[y, x] = (int)state.alive;

                    else if (array[y, x] == (int)state.alive && count == 2)
                        tempArray[y, x] = (int)state.alive;

                    else if (array[y, x] == (int)state.alive && count == 3)
                        tempArray[y, x] = (int)state.alive;

                    else if (array[y, x] == (int)state.alive && count < 2)
                        tempArray[y, x] = (int)state.dead;

                    else if (array[y, x] == (int)state.alive && count > 3)
                        tempArray[y, x] = (int)state.dead;
                }
            }

            //for (int y = 0; y < array.GetLength(0); y++)

            //{

            //    for (int x = 0; x < array.GetLength(1); x++)

            //    {
            //        var count = CountNeighbors(y, x);

            //        if (array[y, x] == (int)state.dead && count == 3)
            //            tempArray[y, x] = (int)state.alive;

            //        if (array[y, x] == (int)state.alive && (count == 2 || count == 3))
            //            tempArray[y, x] = (int)state.alive;


            //    }

            //}
            return tempArray;
        }
    }
}
