using System;
using System.Linq;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();
            int len = number1.Length > number2.Length ? 
                number1.Length : number2.Length;
            int extra = 0;
            string sumstring = "";
            for (int i = len-1; i >= 0; i--)
            { 
                int first = i < number1.Length ? Int32.Parse(number1.ElementAt(i).ToString()) : 0;
                int second = i < number2.Length ? Int32.Parse(number2.ElementAt(i).ToString()) : 0;
                int sum = first + second+extra;
                if (i == 0)
                {
                    sumstring += ReverseString(sum.ToString());
                    break;
                }
                sumstring += (sum % 10).ToString();
                extra = sum / 10;
            }

            sumstring = ReverseString(sumstring);
            sumstring = sumstring.TrimStart(new char[] { '0' });


            Console.WriteLine(sumstring);
        }
        public static string ReverseString(string str)
        {
            char[] rev = new char[str.Length];
            int forward = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev[forward++] = str[i];
            }
            return new string(rev);
        }
    }
}