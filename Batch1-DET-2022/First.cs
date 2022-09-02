using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class First
    {
      public  static void first()
        {
            string[] fruits = { "Banana", "Apple", "Orange" };

            var result = fruits.First();

            Console.WriteLine("First element in the array is:");
            Console.WriteLine(result);
        }
    }
}
