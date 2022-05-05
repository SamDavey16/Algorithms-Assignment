using System;

namespace Quick
{
    class QuickSort
    {
        public void Quicksort(int[] data)
        {
            Quick_Sort(data, 0, data.Length - 1);
        }

        public void Quick_Sort(int[] data, int left, int right)
        {
            int i, j;
            int pivot, temp;

            i = left;
            j = right;
            pivot = data[(left + right) / 2];

            do
            {
                while ((data[i] < pivot) && (i < right)) i++;
                while ((pivot < data[j]) && (j > left)) j--;

                if (i <= j)
                {
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (left < j) Quick_Sort(data, left, j);
            if (i < right) Quick_Sort(data, i, right);
        }

        public void Quicksort_descending(int[] data)
        {
            Quick_Sort_Descending(data, 0, data.Length - 1);
        }

        public void Quick_Sort_Descending(int[] data, int left, int right)
        {
            int i, j;
            int pivot, temp;

            i = left;
            j = right;
            pivot = data[(left + right) / 2];

            do
            {
                while ((data[i] > pivot) && (i < right)) i++;
                while ((pivot > data[j]) && (j > left)) j--;

                if (i <= j)
                {
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (left < j) Quick_Sort_Descending(data, left, j);
            if (i < right) Quick_Sort_Descending(data, i, right);
        }
    }
}