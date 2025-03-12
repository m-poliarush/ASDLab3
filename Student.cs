using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASDLab3
{
    public class Student
    {
        public string Surname { get; }
        public long StudentID { get; }
        public double AverageMark { get; }
        public bool Conference { get; }
        public Student(string Surname, long StudentID, double AverageMark, bool Conference)
        {
            this.AverageMark = AverageMark;
            this.StudentID = StudentID;
            this.Surname = Surname;
            this.Conference = Conference;
        }
        public override string ToString()
        {
            return $"Surname: {Surname},\nStudent ID: {StudentID},\nAverage Mark: {Math.Round(AverageMark, 2)},\nActivity in Conferences: {Conference}";
        }

    }
}
