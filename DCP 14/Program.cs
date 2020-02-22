using System;
using System.IO;
using System.Linq;

namespace DCP_14
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
                string[] numbers = Console.ReadLine().Split(' ');
                decimal ab = Decimal.Parse(numbers[0]);
                decimal bc = Decimal.Parse(numbers[1]);
                decimal cd = Decimal.Parse(numbers[2]);
                decimal ac = (decimal) Math.Sqrt((double) (ab * ab + bc * bc));
                decimal ad = (decimal) Math.Sqrt((double) (ac * ac + cd * cd));
                ad = Math.Round(ad, 2);
                string result = ad.ToString();
                string[] results = result.Split('.');
                if (results.Count()==1)
                {
                    result += ".00";
                }
                else if (results[1].Length == 1)
                    result += "0";
                Console.WriteLine(result);
            }
        }
    }
}
