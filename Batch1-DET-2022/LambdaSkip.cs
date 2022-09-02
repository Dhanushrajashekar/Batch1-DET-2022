using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class LambdaSkip
    {
        public static void Main()
    {
        string[] words = { "one", "two", "three", "four", "five", "six" };

        var result = words.Skip(4);

        Console.WriteLine("Skips the first 4 words:");
        foreach (string word in result)
            Console.WriteLine(word);
    }
    }
}
