using System;
namespace task1
{

    class Program
    {
        //пишу функцию для проверки чисел на prime
        public static bool isprime(int b)
        {
            if (b == 1)
            {
                return false;
            }
            for (int i = 2; i * i <= b; ++i)
            {
                if (b % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static void Main(string[] args)
        {
            //создаю переменную и сохраняю в него количество чисел
            int n = int.Parse(Console.ReadLine());
            //создаю массив строк, считываю с консоли n чисел и разделяю их на каждый элемент массива
            string[] arr = Console.ReadLine().Split();
            //создаю массив чисел
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                //перевожу элементы string в int и сохраняю в массив
                a[i] = int.Parse(arr[i]);
            }
            for (int i = 0; i < n; i++)
            {
                //проверяю и вывожу простые числа
                if (isprime(a[i]) == true)
                    Console.Write(a[i] + " ");
            }
            //ожидание нажатия клавиши
            Console.ReadKey();
        }
    }

}
