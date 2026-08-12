using System;
using StudentLibrary;

namespace StudentClient
{
    class Program
    {
        static void Main4(string[] args)
        {
            Student s = new Student();

            Console.WriteLine("Name: " + s.Name);

            Console.ReadLine();
        }
    }
}