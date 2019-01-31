using System;
namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаю переменную и сохраняю в него размер массива
            int n = int.Parse(Console.ReadLine());
            //создаю 2d массив string
            string[,] arr = new string[n,n];
            //заполняю массив строчками "[*]"
            for(int i = 0; i < n; i++)
            {
                for(int j = 0;j < n; j++){
                    arr[i, j] +="[*]";
            }
            }
            //вывожу на консоль только нужные мне звезды
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(i>=j)
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
