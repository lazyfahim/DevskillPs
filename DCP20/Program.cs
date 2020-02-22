using System;

namespace DCP20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                double cx, cy, r, px, py;
                string[] numbers = Console.ReadLine().Split(' ');
                cx = Double.Parse(numbers[0]);
                cy = Double.Parse(numbers[1]);
                r = Double.Parse(numbers[2]);
                px = Double.Parse(numbers[3]);
                py = Double.Parse(numbers[4]);
                int ans = (int)Math.Sqrt((cx - px) * (cx - px) + (cy - py) * (cy - py));
                if (ans == (int)r)
                    Console.WriteLine($"Case {i}: OnCircle");
                else if (ans > r)
                    Console.WriteLine($"Case {i}: Outside");
                else
                    Console.WriteLine($"Case {i}: Inside");
            }


        }
    }
}
