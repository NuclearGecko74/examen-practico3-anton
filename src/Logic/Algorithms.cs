﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPractico3.src.Logic
{
    public static class Algorithms
    {
        // Public Methods
        // ------------------------------------------------
        public static void QuickSort(List<Student> students)
        {
            QuickSort(students, 0, students.Count - 1);
        }

        // Search by name
        public static Student LinearSearchName(List<Student> students, string target)
        {
            foreach (var student in students)
            {
                if (student.name == target) return student;
            }
            return null;
        }

        // Search by matricula
        public static Student LinearSearchMatricula(List<Student> students, string target)
        {
            foreach (var student in students)
            {
                if (student.matricula == target) return student;
            }
            return null;
        }

        // Private Methods
        // ------------------------------------------------
        private static void QuickSort(List<Student> students, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex) return;

            int pivotIndex = Pivot(students, leftIndex, rightIndex);
            QuickSort(students, leftIndex, pivotIndex - 1);
            QuickSort(students, pivotIndex + 1, rightIndex);
        }

        private static int Pivot(List<Student> students, int pivotIndex, int endIndex)
        {
            int swapIndex = pivotIndex;
            for(int i = pivotIndex + 1; i <= endIndex; i++)
            {
                if (students[i].promedio > students[pivotIndex].promedio)
                {
                    swapIndex++;
                    Swap(students, swapIndex, i);
                }
            }
            Swap(students, pivotIndex, swapIndex);
            return swapIndex;
        }

        private static void Swap(List<Student> students, int firstIndex, int SecondIndex)
        {
            Student temp = students[firstIndex];
            students[firstIndex] = students[SecondIndex];
            students[SecondIndex] = temp;
        }
    }
}
