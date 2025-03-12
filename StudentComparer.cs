using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASDLab3
{
    public class StudentComparer : IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            if (s1.StudentID > s2.StudentID)
            {
                return 1;
            }
            else if (s1.StudentID < s2.StudentID)
            {
                return -1;
            }
            else return 0;
        }
    }
}
