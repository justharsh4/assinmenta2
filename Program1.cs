using System;

namespace Lab1_AccessModifiers
{
    class Student
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

        public void Display()
        {
            Console.WriteLine("\nName: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("CGPA: " + CGPA);
            Console.WriteLine("College: " + College);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("\nDevelop By Harsh Pachauri [26]");

        }
    }

    class Program1
    {
        static void Main1(string[] args)
        {
            Student s = new Student();
            s.Input();
            s.Display();
            Console.ReadLine();
        }
    }
}