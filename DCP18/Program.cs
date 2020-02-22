using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DCP18
{
    class Program
    {
        static void Main(string[] args)
        {
#if !ONLINE_JUDGE
            Console.SetIn(File.OpenText("file.txt"));
            //Console.SetOut(File.CreateText("out.txt"));
#endif
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int p = Int32.Parse(Console.ReadLine());
                List<string> number = new List<string>();
                string numbers = Console.ReadLine();
                number = new List<string>(numbers.Split(' '));
                Comparison cmp = new Comparison();
                number.Sort(cmp);
                var lastnum = number.LastOrDefault();
                foreach (var num in number)
                {
                    if (num == lastnum)
                        break;
                    Console.Write(num + ',');
                }
                Console.WriteLine(lastnum);
            }
        }
    }
    class Comparison : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            double a = Double.Parse(x);
            double b = Double.Parse(y);
            if (a > b)
                return 1;
            else if (b > a)
                return -1;
            return 1;
        }
    }
}
