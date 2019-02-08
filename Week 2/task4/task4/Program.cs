using System;
using System.IO;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathString = Path.Combine(@"C:\path");
            string fileName = "example.txt";
            pathString = Path.Combine(pathString, fileName);
            FileStream fs = File.Create(pathString);
            //Закрываю поток
            fs.Close();


            //Источник
            string sourcePath = @"C:\path";
            // Цель
            string targetPath = @"C:\path1";
            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(targetPath, fileName);

            Directory.CreateDirectory(targetPath);

            // Чтобы скопировать файл в другое место 
            // и перезаписать файл назначения, если он уже существует.

            File.Copy(sourceFile, destFile, true);


            if (File.Exists(@"C:\path\example.txt"))
            {
                try
                {
                    File.Delete(@"C:\path\example.txt");
                }
                catch (IOException a)
                {
                    Console.WriteLine(a.Message);
                    return;
                }
            }
            Console.ReadKey();
        }
    }
}