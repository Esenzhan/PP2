using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
namespace task2
{
    public class Mark
    {   
        [XmlIgnore]
        public string[] let = { "D", "D+", "C-", "C", "C+", "B-", "B", "B+", "A-", "A" };
        public int points;
        public string letter;
        public List<Mark> students;
        public Mark()
        {
            students = new List<Mark>();
        }
        public Mark(int points)
        {
            this.points = points;
            if (points < 50)
                this.letter = "F";
            else
            this.letter = let[(points - 50) / 5];
        }
        public override string ToString()
        {
            return points + " " + letter;
        }
    }

    class Program
    {
        public static void Ser()
        {
            Mark stud = new Mark();
            Mark Esen = new Mark(48);
            Mark Ernur = new Mark(74);
            Mark Aziz = new Mark(95);
            Mark Ali = new Mark(56);
            stud.students.Add(Esen);
            stud.students.Add(Ernur);
            stud.students.Add(Aziz);
            stud.students.Add(Ali);
            FileStream fs = new FileStream("stud.xml", FileMode.Truncate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Mark));
            xs.Serialize(fs, stud);
            fs.Close();
        }
        public static void DeSer()
        {
            FileStream fs = null;
            fs = new FileStream("stud.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Mark));
            Mark stud = xs.Deserialize(fs) as Mark;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(stud.students[i]);
            }
            Console.ReadKey();
            fs.Close();
        }
        static void Main(string[] args)
        {
            Ser();
            DeSer();
        }
    }
}