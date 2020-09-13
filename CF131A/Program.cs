using System;
using System.IO;

namespace CF131A
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
            if(IsCaps(str))
            {
                for(int i=0;i<str.Length;i++)
                {
                    if (Char.IsUpper(str[i]))
                        str[i] = Char.ToLower(str[i]);
                    else
                        str[i] = Char.ToUpper(str[i]);
                }
            }
            Console.WriteLine(str);
        }
        static private bool IsCaps(char[] s)
        {
            bool firstletterUpper = false;
            if (Char.IsUpper(s[0]) == true)
                firstletterUpper = true;
            bool allupper = true;
            for(int i=1;i<s.Length;i++)
            {
                if(Char.IsLower(s[i]))
                {
                    allupper = false;
                    break;
                }
            }
            if (allupper == true && firstletterUpper == true)
                return true;
            else if (firstletterUpper == false && allupper == true)
                return true;
            return false;
        }
    }
}
