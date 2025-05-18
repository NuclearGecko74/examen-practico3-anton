using ExamenPractico3.src.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPractico3.src.DataStructures
{
    internal class StudentNode
    {
        public Student student;
        StudentNode left;
        StudentNode right;

        public StudentNode(Student student)
        {
            this.student = student;
            left = null;
            right = null;
        }
    }
}