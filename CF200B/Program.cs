using System;
using System.IO;
using System.Linq;

namespace CF200B
{
    class Program
    {
        static void Main(string[] args)
        {
#if !ONLINE_JUDGE
            Console.SetIn(File.OpenText("file.txt"));
#endif
            int n = Int32.Parse(Console.ReadLine());
            int[] num = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x));
            int sum = 0;
            Array.ForEach(num, x => sum += x);
            double res = (double)sum /n ;
            Console.WriteLine(res);
        }
    }
}
