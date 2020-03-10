using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace DataPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = new char();
            Console.WriteLine($"the character default value is {a}");

        }
    }

    public class Student
    {
        public string name;
        public int rollNumber;
        public int age;

        public Student(string name, int age, int rollNumber)
        {
            this.name = name;
            this.age = age;
            this.rollNumber = rollNumber;
        }
    }
}
