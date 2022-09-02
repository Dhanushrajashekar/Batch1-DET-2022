using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class ArrayMax
    {
        public static void Main()
        {
            string[] names = { "John", "Peter", "Jacob", "Harry", "Jackson"};

            var names2 =  names.OrderByDescending(x => x.Length);
            var biggest = names2.Take(1);

            foreach (var name in biggest)
            {
                Console.WriteLine(name);
            }
        }
    }
    
}
