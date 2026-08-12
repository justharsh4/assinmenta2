using System;

namespace Lab1_AccessModifiers
{
    class Student2
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

    class GraduateStudent : Student
    {
        public void ShowData()
        {
            Console.WriteLine("\nStudent Details");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("CGPA: " + CGPA);
            Console.WriteLine("College: " + College);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("\nDevelop By Harsh Pachauri [26]");

        }
    }

    class Program2
    {
        static void Main3(string[] args)
        {
            GraduateStudent g = new GraduateStudent();

            g.Input();
            g.ShowData();

            Console.ReadLine();
        }
    }
}