using System;

namespace Lab1_AccessModifiers
{
    class Student1
    {
        public string Name;
        private int Age;
        protected string Department;
        internal double CGPA;
        protected internal string College;
        private protected string Address;

        public void Input()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Department: ");
            Department = Console.ReadLine();

            Console.Write("Enter CGPA: ");
            CGPA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter College: ");
            College = Console.ReadLine();

            Console.Write("Enter Address: ");
            Address = Console.ReadLine();
        }
    }

    class TestStudent
    {
        public void Show()
        {
            Student s = new Student();

            s.Input();

            Console.WriteLine("\nDevelop By Harsh Pachauri [26]");
            Console.WriteLine("Name: " + s.Name);
            Console.WriteLine("CGPA: " + s.CGPA);
            Console.WriteLine("College: " + s.College);
        }
    }

    class Program1
    {
        static void Main2(string[] args)
        {
            TestStudent t = new TestStudent();
            t.Show();

            Console.ReadLine();
        }
    }
}