using System;
using System.IO;
namespace task2
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
        static void Main(string[] args)
        {
            //создаю класс StreamReader для чтения текстового файла
            StreamReader str = new StreamReader(@"C:\Users\123\Desktop\PP2\Week 2\task2\task2\input.txt");
            //создаю класс StreanWriter для записи в текстовой файл
            StreamWriter st = new StreamWriter(@"C:\Users\123\Desktop\PP2\Week 2\task2\task2\output.txt");
            string[] s = str.ReadToEnd().Split();
            int[] arr = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                arr[i] = int.Parse(s[i]);
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (isprime(arr[i]) == true)
                {                       
                    st.Write(arr[i] + " ");
                }
            }
            st.Close();
        }
    }
}