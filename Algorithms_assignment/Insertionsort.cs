using System;

namespace Insertion
{
    class Insertionsort
    {
        public void InsertionSort(int[] data)
        {
            int numSorted = 1;
            int index;
            while (numSorted < data.Length)
            {
                int temp = data[numSorted];
                for (index = numSorted; index > 0; index--)
                {
                    if (temp < data[index - 1])
                    {
                        data[index] = data[index - 1];
                    }
                    else
                    {
                        break;
                    }
                }
                data[index] = temp;
                numSorted++;
            }
        }

        public void InsertionSort_Descending(int[] data)
        {
            int numSorted = 1;
            int index;
            while (numSorted < data.Length)
            {
                int temp = data[numSorted];
                for (index = numSorted; index > 0; index--)
                {
                    if (temp > data[index - 1])
                    {
                        data[index] = data[index - 1];
                    }
                    else
                    {
                        break;
                    }
                }
                data[index] = temp;
                numSorted++;
            }
        }
    }
}