using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
namespace task1
{
    public class ComNumb
    {
        public int real;
        public int im;
        public List<ComNumb> numbers;
        public ComNumb()
        {
            numbers = new List<ComNumb>();
        }
        public ComNumb(int real, int im)
        {
            this.real = real;
            this.im = im;
        }
        public override string ToString()
        {
            if (im > 0)
                return real + "+" + im + "i";
            else return real +""+ im + "i";
        }

    }
    class Program
    {
        public static void Ser()
        {
            ComNumb num = new ComNumb();
            ComNumb num1 = new ComNumb(2, -3);
            ComNumb num2 = new ComNumb(4, 5);
            num.numbers.Add(num1);
            num.numbers.Add(num2);
            FileStream fs = new FileStream("num.xml", FileMode.Truncate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(ComNumb));
            xs.Serialize(fs, num);
            fs.Close();
        }
        public static void DeSer()
        {
            FileStream fs = null;
            fs = new FileStream("num.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(ComNumb));
            ComNumb num = xs.Deserialize(fs) as ComNumb;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(num.numbers[i]);
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Ser();
            DeSer();
        }
    }
}
