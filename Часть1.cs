using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Student
    {
        private string name;
        private int sumb;
        private Random rnd { get; set; }
        public void SetValue(string newname)
        {
            name = newname;
            rnd = new Random();
            sumb = rnd.Next(100);
        }
        public void PrintValue()
        {
            string Sname = name.ToString();
            string Ssumb = sumb.ToString();
            Console.WriteLine("Student name : {0}, summ of score = {1} ", Sname, Ssumb);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[3];
            string[] names = new string[3] { "Maxim Pijevskiy", "Dmitry Morgun", "Dmitry Khasiev" };
            for(int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
                students[i].SetValue(names[i]);
            }
            for(int i = 0; i < students.Length; i++)
            {
                students[i].PrintValue();
            }
        }
    }
}
