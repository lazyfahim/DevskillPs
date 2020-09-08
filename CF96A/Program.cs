using System;
using System.IO;

namespace CF96A
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
            int countzero = 0;
            int countone = 0;
            bool dangerous = false;
            foreach(char num in s)
            {
                if(num=='0')
                {
                    countone = 0;
                    countzero++;
                }
                else
                {
                    countzero = 0;
                    countone++;
                }
                if(countone >= 7 || countzero>=7)
                {
                    dangerous = true;
                    break;
                }
            }
            if (dangerous == true)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
