using System;
using System.IO;
using System.Linq;

namespace CF977A
{
    class Program
    {
        static void Main(string[] args)
        {
            String s;
#if !ONLINE_JUDGE
            Console.SetIn(File.OpenText("file.txt"));
            //Console.SetOut(File.CreateText("out.txt"));
#endif
            s = Console.ReadLine();
            long[] num = Array.ConvertAll(s.Split(' '),x => long.Parse(x));
            long n = num[0];
            for(int i=1;i<=num[1];i++)
            {
                if (n % 10 == 0)
                    n /= 10;
                else
                    n--;
            }
            Console.WriteLine(n);
        }
    }
}
