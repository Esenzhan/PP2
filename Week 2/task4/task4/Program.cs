using System;
using System.IO;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Считываю путь, где надо создать файл
            string path1 = Console.ReadLine();
            //Считываю путь, куда надо скопировать файл
            string path2 = Console.ReadLine();
            //Комбинирую первый путь с названием файла
            path1 = Path.Combine(path1, "example.txt");
            //Комбинирую второй путь с названием файла
            path2 = Path.Combine(path2, "example.txt");
            //Создаю файл по первому пути
            FileStream fs = File.Create(path1);
            //Закрываю поток
            fs.Close();
            //Копирую файл из path в path1
            File.Copy(path1, path2, true);
            //Удаляю файл по заданному пути
            File.Delete(path1);              
        }
    }
}