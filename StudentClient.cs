using System;
using StudentLibrary;

namespace StudentClient
{
    class ResearchStudent : Student
    {
        public void ShowData()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("College: " + College);
             
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            ResearchStudent r = new ResearchStudent();
            r.ShowData();
            Console.ReadLine();
        }
    }
}