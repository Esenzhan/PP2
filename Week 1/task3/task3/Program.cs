using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаю переменную и сохраняю в него количество вводимых чисел
            int n = int.Parse(Console.ReadLine());
            //создаю массив строк, считываю с консоли n чисел и разделяю их на каждый элемент массива
            string[] arr = Console.ReadLine().Split();
            //создаю массив чисел с размером n*2, т.к.числа повторяются дважды
            int[] a = new int[n * 2];
            //создаю переменную, чтобы использовать ее при заполнении массива чисел
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    //заполняю масссив с повторяюшимися цифрами
                    a[k] = int.Parse(arr[i]);
                    k++;
                }
            }
            for (int i = 0; i < n * 2; i++)
            {
                //вывожу на консоль
                Console.Write(a[i] + " ");
            }
            Console.ReadKey();

        }
    }
}

