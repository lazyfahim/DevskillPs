using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
#if !ONLINE_JUDGE
            Console.SetIn(File.OpenText("file.txt"));
            //Console.SetOut(File.CreateText("out.txt"));
#endif
            int n  = Int32.Parse(Console.ReadLine());
            List<(string,int,string)> peoples = new List<(string, int, string)>();
            for(int i = 1; i<=n ; i++)
            {
                string name = Console.ReadLine();
                int age = Int32.Parse(Console.ReadLine());
                string city = Console.ReadLine();
                peoples.Add((name,age,city));
            }
            Comparison comparison = new Comparison();
            peoples.Sort(comparison);
            foreach (var people in peoples)
            {
                Console.WriteLine($"Name: {people.Item1} Age: {people.Item2} City: {people.Item3}");
            }
        }
    }
    class Comparison:IComparer<(string,int,string)>
    {
        public int Compare((string,int, string) people1,
            (string,int, string) people2)
        {
            if ( people1.Item1.CompareTo(people2.Item1) > 0)
                return -1;
            else if ( people1.Item1.CompareTo(people2.Item1) < 0)
                return 1;
            if (people1.Item2 > people2.Item2)
                return 1;
            else if(people1.Item2 < people2.Item2)
                return -1;
            if ( people1.Item3.CompareTo(people2.Item3) > 0)
                return -1;
            else if (people1.Item3.CompareTo(people2.Item3) < 0)
                return 1;
            else return 0;
        }
    }
}
