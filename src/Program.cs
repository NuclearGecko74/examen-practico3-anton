using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExamenPractico3.src.Logic;

namespace ExamenPractico3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Antonia", "5212539", 8.7f));
            students.Add(new Student("Anton", "5112539", 9.7f));

            Algorithms.QuickSort(students);

            foreach(var student in students)
            {
                Console.WriteLine(student.name);
            }
        }
    }
}
