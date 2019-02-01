using System;
namespace task2
{
    class Student
    {
        public string name;
        public string id;
        public int year;
        //создаю конструктор с 2 параметрами
        public Student(string name,string id)
        {
            this.name = name;
            this.id = id;
        }
        //создаю метод
        public void print(int year)
        {
            Console.WriteLine("name:          " + name);
            Console.WriteLine("ID:            " + id);
            Console.WriteLine("Year of study: " + (++year));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string i = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Student st1 = new Student(s,i);
            st1.print(n);
            Console.ReadKey();
        }
    }
}