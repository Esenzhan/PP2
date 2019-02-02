using System;
using System.IO;
namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаю класс StreamReader для считывания текста из текстового файла
            StreamReader str = new StreamReader(@"C:\Users\123\Desktop\PP2\Week 2\task1\task1\input.txt");
            //считываем текстовый файл до конца и сохраняем в переменную string
            string s = str.ReadToEnd();
            int k = (s.Length - 1);
            for(int i = 0; i < (s.Length/2); i++)
            {
                if (s[i] != s[k])
                {
                    Console.WriteLine("No");
                    Console.ReadKey();
                    return;
                }
                k--;
            }
            Console.WriteLine("Yes");
            Console.ReadKey();
        }
    }
}
