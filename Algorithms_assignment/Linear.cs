using System;

namespace Linear
{
    class LinearSearch
    {
        public void linearSearch(int x, int[] arr)
        {
            int v = 0;
            foreach (var item in arr)
            {
                if (x == arr[v])
                {
                    Console.WriteLine("The Value is at position: " + v + "in the array");
                    break;
                }
                else
                {
                    v += 1;
                }
            }
        }
    }
}