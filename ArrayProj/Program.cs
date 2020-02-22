using System;
using System.Collections.Generic;

namespace ArrayProj
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> twod = new List<List<int>>(20);
            twod[0].Add(5);
            Console.WriteLine(twod[0][1]);

        }
    }
}
