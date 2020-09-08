using System;
using System.IO;

namespace CF281A
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
            char[] str = s.ToCharArray();
            if (str[0] >= 97 && str[0] <= 122)
                str[0] =(char) (str[0]-32);
            Console.WriteLine(str);
        }
    }
}
