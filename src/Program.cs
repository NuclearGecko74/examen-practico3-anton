using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenPractico3.src.DataStructures;
using ExamenPractico3.src.Logic;

namespace ExamenPractico3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1
            List<Student> students = new List<Student>();
            students.Add(new Student("Valerie", "5212539", 6.5f));
            students.Add(new Student("Anton", "5112539", 9.7f));

            Algorithms.QuickSort(students);

            foreach(var student in students)
            {
                Console.WriteLine(student.name);
            }

            // Example 2
            StudentBST bts = new StudentBST(new Student("Valerie", "5212539", 6.5f));
            bts.InsertStudent(new Student("Anton", "5112539", 9.7f));

            Student student2 = bts.FindByMatricula("5112539");
            if (student2 != null)
            {
                Console.WriteLine("Name: " + student2.name);
                Console.WriteLine("Matricula: " + student2.matricula);
                Console.WriteLine("Promedio: " + student2.promedio);
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
    }
}
