using System;
using System.Linq;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int i = 0;
            int end = n;
            while (i < (n * 2))
            {
                int i1;
                if (i <= n)
                    i1 = i;
                else
                    i1 = ((n*2)-i);
                for(int p = 1; p <= end ;p++)
                    Console.Write(" ");
                for(int p = 1; p <= (2*i1-1) ; p++)
                    Console.Write("*");
                if (i < n)
                    end--;
                else
                    end++;
                Console.WriteLine();
                i++;
            }
        }
    }
}