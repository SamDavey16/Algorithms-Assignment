using System;
using System.Collections.Generic;
using System.IO;

namespace larger
{
    class largerfile
    {
        public void Larger_file()
        {
            int[] Traffic_Numbers_2048;
            List<string> Traffic = new List<string>();
            String line;
            StreamReader sr = new StreamReader("C:\\Users\\Samda\\Desktop\\Algorithms\\Algorithms_assignment\\Net_1_2048.txt");
            line = sr.ReadLine();
            while (line != null)
            {
                Traffic.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();
            Traffic_Numbers_2048 = Array.ConvertAll(Traffic.ToArray(), int.Parse);
            //BinarySearch(26107, Traffic_Numbers, 0, 256);

            int[] Traffic_Numbers_2_2048;
            List<string> Traffic_2 = new List<string>();
            String line_2;
            StreamReader sr_2 = new StreamReader("C:\\Users\\Samda\\Desktop\\Algorithms\\Algorithms_assignment\\Net_2_2048.txt");
            line_2 = sr_2.ReadLine();
            while (line_2 != null)
            {
                Traffic_2.Add(line_2);
                line_2 = sr_2.ReadLine();
            }
            sr_2.Close();
            Traffic_Numbers_2_2048 = Array.ConvertAll(Traffic_2.ToArray(), int.Parse);

            int[] Traffic_Numbers_3_2048;
            List<string> Traffic_3 = new List<string>();
            String line_3;
            StreamReader sr_3 = new StreamReader("C:\\Users\\Samda\\Desktop\\Algorithms\\Algorithms_assignment\\Net_3_2048.txt");
            line_3 = sr_3.ReadLine();
            while (line_3 != null)
            {
                Traffic_3.Add(line_3);
                line_3 = sr_3.ReadLine();
            }
            sr_3.Close();
            Traffic_Numbers_3_2048 = Array.ConvertAll(Traffic_3.ToArray(), int.Parse);
        }
    }
}