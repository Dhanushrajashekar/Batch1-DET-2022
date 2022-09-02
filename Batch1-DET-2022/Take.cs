using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Take
    {
       public static void take()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = numbers.Take(7);

            Debug.WriteLine("Takes the first 5 numbers only:");
            foreach (int number in result)
                Debug.WriteLine(number);
        }
    }
}
