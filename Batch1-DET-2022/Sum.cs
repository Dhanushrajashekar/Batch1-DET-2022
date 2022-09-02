using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Sum
    {
      public  static void sum()
        {
            int[] numbers = { 2, 5, 10 };

            var result = numbers.Sum();

            Debug.WriteLine("Summing the numbers yields:");
            Debug.WriteLine(result);
        }
    }
}
