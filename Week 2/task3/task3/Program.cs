using System;
using System.IO;

namespace task3
{
    class Program
    {
        //создаю функцию для создания табов
        public static void PrintSpaces(int n){
        for(int i = 0; i < n; i++)
            {
                Console.Write("      ");
            }
        }
        //создаю функцию для выведения на консоль всех папок и файлов по заданному пути
        public static void Director(DirectoryInfo dir,int a)
        {
            foreach(FileInfo f in dir.GetFiles()){
                PrintSpaces(a);
                Console.WriteLine(f.Name);
            }
            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                PrintSpaces(a);
                Console.WriteLine(d.Name);
              
                Director(d, a+1);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo df = new DirectoryInfo(@"C:\Users\123\Desktop\C##");
            int b = 0;
            Director(df, b);
            Console.ReadKey();
        }
    }
}
