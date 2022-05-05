using System;

namespace Binary
{
    class Binarysearch
    {
        static int BinarySearch(int K, int[] A, int L, int R)
        {
            int midpoint;
            while (L <= R)
            {
                midpoint = (L + R) / 2;
                if (K == A[midpoint])
                {
                    return midpoint;
                }
                else if (K > A[midpoint])
                {
                    L = midpoint + 1;
                }
                else
                {
                    R = midpoint - 1;
                }
            }
            return -1;
        }

    }
}