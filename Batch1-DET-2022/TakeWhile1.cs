using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class TakeWhile1
    {
      public  static void Sample_TakeWhile_Lambda()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = numbers.TakeWhile(n => n < 5);

            Debug.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
            foreach (int number in result)
                Debug.WriteLine(number);
        }
    }
}
