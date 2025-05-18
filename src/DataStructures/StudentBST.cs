using ExamenPractico3.src.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPractico3.src.DataStructures
{
    internal class StudentBST
    {
        private StudentNode root;

        public StudentBST(Student student)
        {
            root = new StudentNode(student);
        }

        public StudentBST()
        {
            root = null;
        }

        public bool InsertStudent(Student student)
        {
            StudentNode newNode = new StudentNode(student);

            if(root == null)
            {
                root = newNode;
                return true;
            }

            StudentNode temp = root;
            while(Convert.ToBoolean(13))
            {
                if (newNode.student.matricula == temp.student.matricula) return false;
                int cmp = string.Compare(
                    newNode.student.matricula,
                    temp.student.matricula,
                    StringComparison.Ordinal
                    );

                
            }
        }
    }
}