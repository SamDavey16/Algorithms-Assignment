using System;
using System.Collections.Generic;
using System.IO;
using Bubblesort;
using Insertion;
using Quick;
using HeapSort;
using Linear;

namespace Algorithms_assignment
{
    class Algorithms
    {
        public static int[] merge_arrays(int[] array_1, int[] array_2)
        {
            int[] array_3 = new int[array_1.Length + array_2.Length];
            Array.Copy(array_1, 0, array_3, 0, array_1.Length);
            Array.Copy(array_2, 0, array_3, array_1.Length, array_2.Length);
            return array_3;
        }
        public static void display_nth(int[] array_choice)
        {
            int incr;
            if (array_choice.Length <= 612)
            {
                incr = 10;
            }
            else
            {
                incr = 50;
            }
            int i = 0;
            while (i + incr < array_choice.Length-1)
            {
                i += incr;
                Console.WriteLine(array_choice[i]);
            }
        }
        public static void BinarySearch(int K, int[] A, int L, int R)
        {
            int midpoint;
            int closest_position_up = 0;
            int closest_position_down = 0;
            int difference_up = 99999;
            int difference_down = 99999;

            while (L <= R)
            {
                midpoint = (L + R) / 2;
                if (K == A[midpoint])
                {
                    Console.WriteLine("The value " + K + "is at location: " + midpoint);
                    break;
                }
                else if (K > A[midpoint]) // Search val is greater than value at midpoint
                {
                    L = midpoint + 1;
                    if (K - A[midpoint] < difference_down) // If the difference between K and the element at the midpoint is less than the current closest down
                    {
                        closest_position_down = midpoint; // Save the position of the closest down
                        difference_down = K - A[midpoint]; // Save the difference
                    }
                }
                else if (K < A[midpoint]) // Search val is less than value at midpoint
                {
                    R = midpoint - 1;
                    if (A[midpoint] - K < difference_up)
                    {
                        closest_position_up = midpoint;
                        difference_up = A[midpoint] - K;
                    }
                }
            }

            if (difference_down == difference_up)
            {
                Console.WriteLine("The closest value above it is: " + A[closest_position_up] + " and is at position " + closest_position_up);
                Console.WriteLine("The closest value below it is: " + A[closest_position_down] + " and is at position " + closest_position_down);
            }
            else if (difference_up < difference_down)
            {
                Console.WriteLine("The closest value is " + A[closest_position_up] + " and is at position " + closest_position_up);
            }
            else
            {
                Console.WriteLine("The closest value is: " + A[closest_position_down] + " and is at position " + closest_position_down);
            }
        }

        public static void choices(int[] array_choice, string Sort_choice, int array_size)
        {
            string search_choice;
            if (Sort_choice.Equals("1"))
            {
                BubbleSort b = new BubbleSort();
                b.bubbleSort_descending(array_choice, array_size);
                display_nth(array_choice);
                Console.WriteLine();
                b.bubbleSort(array_choice, array_size);
                display_nth(array_choice);
                Console.WriteLine("Would you like to search with (1) Linear Search or (2) Binary Search? ");
                search_choice  = Console.ReadLine();
                if (search_choice == ("1"))
                {
                    int number;
                    Console.WriteLine("Enter your value: ");
                    number = Int32.Parse(Console.ReadLine());
                    LinearSearch a = new LinearSearch();
                    a.linearSearch(number, array_choice);
                }
                else if (search_choice == ("2"))
                {
                    int number;
                    Console.WriteLine("Enter your value: ");
                    number = Int32.Parse(Console.ReadLine());
                    BinarySearch(number, array_choice, 0, array_size);
                }
            }
            else if (Sort_choice.Equals("2"))
            {
                Heap h = new Heap();
                h.HeapSort_Descending(array_choice);
                display_nth(array_choice);
                Console.WriteLine();
                h.HeapSort(array_choice);
                display_nth(array_choice);
                Console.WriteLine("Would you like to search with (1) Linear Search or (2) Binary Search? ");
                search_choice = Console.ReadLine();
                if (search_choice == ("1"))
                {
                    int number;
                    Console.WriteLine("Enter your value: ");
                    number = Int32.Parse(Console.ReadLine());
                    LinearSearch a = new LinearSearch();
                    a.linearSearch(number, array_choice);
                }
                else if (search_choice == ("2"))
                {
                    int number;
                    Console.WriteLine("Enter your value: ");
                    number = Int32.Parse(Console.ReadLine());
                    BinarySearch(number, array_choice, 0, array_size);
                }
            }
            else if (Sort_choice.Equals("3"))
            {
                Insertionsort s = new Insertionsort();
                s.InsertionSort_Descending(array_choice);
                display_nth(array_choice);
                Console.WriteLine();
                s.InsertionSort(array_choice);
                display_nth(array_choice);
                Console.WriteLine("Would you like to search with (1) Linear Search or (2) Binary Search? ");
                search_choice = Console.ReadLine();
                if (search_choice.Equals("1"))
                {
                    int number;
                    Console.WriteLine("Enter your value: ");
                    number = Int32.Parse(Console.ReadLine());
                    LinearSearch a = new LinearSearch();
                    a.linearSearch(number, array_choice);
                }
                else if (search_choice.Equals("2"))
                {
                    int number;
                    Console.WriteLine("Enter your value: ");
                    number = Int32.Parse(Console.ReadLine());
                    BinarySearch(number, array_choice, 0, array_size);
                }
            }
            else if (Sort_choice.Equals("4"))
            {
                QuickSort x = new QuickSort();
                x.Quicksort_descending(array_choice);
                display_nth(array_choice);
                Console.WriteLine();
                x.Quicksort(array_choice);
                display_nth(array_choice);
                Console.WriteLine("Would you like to search with (1) Linear Search or (2) Binary Search? ");
                search_choice = Console.ReadLine();
                if (search_choice.Equals("1"))
                {
                    int number;
                    Console.WriteLine("Enter your value: ");
                    number = Int32.Parse(Console.ReadLine());
                    LinearSearch a = new LinearSearch();
                    a.linearSearch(number, array_choice);
                }
                else if (search_choice.Equals("2"))
                {
                    int number;
                    Console.WriteLine("Enter your value: ");
                    number = Int32.Parse(Console.ReadLine());
                    BinarySearch(number, array_choice, 0, array_size);
                }
            }
            
        }
        static void Main(string[] args)
        {
            int[] Traffic_Numbers;
            List<string> Traffic = new List<string>();
            String line;
            StreamReader sr = new StreamReader(@"Net_1_256.txt");
            line = sr.ReadLine();
            while (line != null)
            {
                Traffic.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();
            Traffic_Numbers = Array.ConvertAll(Traffic.ToArray(), int.Parse);

            int[] Traffic_Numbers_2;
            List<string> Traffic_2 = new List<string>();
            String line_2;
            StreamReader sr_2 = new StreamReader(@"Net_2_256.txt");
            line_2 = sr_2.ReadLine();
            while (line_2 != null)
            {
                Traffic_2.Add(line_2);
                line_2 = sr_2.ReadLine();
            }
            sr_2.Close();
            Traffic_Numbers_2 = Array.ConvertAll(Traffic_2.ToArray(), int.Parse);

            int[] Traffic_Numbers_3;
            List<string> Traffic_3 = new List<string>();
            String line_3;
            StreamReader sr_3 = new StreamReader(@"Net_3_256.txt");
            line_3 = sr_3.ReadLine();
            while (line_3 != null)
            {
                Traffic_3.Add(line_3);
                line_3 = sr_3.ReadLine();
            }
            sr_3.Close();
            Traffic_Numbers_3 = Array.ConvertAll(Traffic_3.ToArray(), int.Parse);

            int[] Traffic_Numbers_4;
            List<string> Traffic_4 = new List<string>();
            String line_4;
            StreamReader sr_4 = new StreamReader(@"Net_1_2048.txt");
            line_4 = sr_4.ReadLine();
            while (line_4 != null)
            {
                Traffic_4.Add(line_4);
                line_4 = sr_4.ReadLine();
            }
            sr_4.Close();
            Traffic_Numbers_4 = Array.ConvertAll(Traffic_4.ToArray(), int.Parse);

            int[] Traffic_Numbers_5;
            List<string> Traffic_5 = new List<string>();
            String line_5;
            StreamReader sr_5 = new StreamReader(@"Net_2_2048.txt");
            line_5 = sr_5.ReadLine();
            while (line_5 != null)
            {
                Traffic_5.Add(line_5);
                line_5 = sr_5.ReadLine();
            }
            sr_5.Close();
            Traffic_Numbers_5 = Array.ConvertAll(Traffic_5.ToArray(), int.Parse);

            int[] Traffic_Numbers_6;
            List<string> Traffic_6 = new List<string>();
            String line_6;
            StreamReader sr_6 = new StreamReader("Net_3_2048.txt");
            line_6 = sr_6.ReadLine();
            while (line_6 != null)
            {
                Traffic_6.Add(line_6);
                line_6 = sr_6.ReadLine();
            }
            sr_6.Close();
            Traffic_Numbers_6 = Array.ConvertAll(Traffic_6.ToArray(), int.Parse);

            //BinarySearch(26107, Traffic_Numbers, 0, 256);
            Console.WriteLine("Would you like: (1) Bubble Sort, (2) Heap Sort, (3) Insertion Sort, (4) Quick Sort?");
            string Sort_choice = Console.ReadLine();
            Console.WriteLine("Would you like to sort and search 1 (256), 2 (256), 3 (256), 4 (2048), 5 (2048) or 6 (2048)? ");
            string arr_choice = Console.ReadLine();
            if (arr_choice.Equals("1"))
            {
                choices(Traffic_Numbers, Sort_choice, 256);
            }
            else if (arr_choice.Equals("2"))
            {
                choices(Traffic_Numbers_2, Sort_choice, 256);
            }
            else if (arr_choice.Equals("3"))
            {
                choices(Traffic_Numbers_3, Sort_choice, 256);
            }
            else if (arr_choice.Equals("4"))
            {
                choices(Traffic_Numbers_4, Sort_choice, 2048);
            }
            else if (arr_choice.Equals("5"))
            {
                choices(Traffic_Numbers_5, Sort_choice, 2048);
            }
            else if (arr_choice.Equals("6"))
            {
                choices(Traffic_Numbers_6, Sort_choice, 2048);
            }

            int[] merge256 = merge_arrays(Traffic_Numbers, Traffic_Numbers_3);
            int[] merge2048 = merge_arrays(Traffic_Numbers_4, Traffic_Numbers_6);

            Console.WriteLine("Would you like: (1) Bubble Sort, (2) Heap Sort, (3) Insertion Sort, (4) Quick Sort?");
            Sort_choice = Console.ReadLine();
            choices(merge256, Sort_choice, 512);
            display_nth(merge256);
            Console.WriteLine("Would you like: (1) Bubble Sort, (2) Heap Sort, (3) Insertion Sort, (4) Quick Sort?");
            Sort_choice = Console.ReadLine();
            choices(merge2048, Sort_choice, 4096);
            display_nth(merge2048);


        }
    }
}
