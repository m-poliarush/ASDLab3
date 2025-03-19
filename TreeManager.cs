using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASDLab3
{
    public static class BinaryTreeExtension
    {
        public static void PrintTree(this BinaryTree tree)
        {
            Console.WriteLine($"{"Surname",-15} {"Card ID",-10}{"Average Mark",-15}{"Actions in conferences",-10}");
            foreach (Student student in tree)
            {
                Console.WriteLine($"{student.Surname,-15} {student.StudentID,-10} {student.AverageMark,-15}{student.Conference,-10}");
            }
        }
        public static List<Student> FindStudents(this BinaryTree tree, double AverageMark, bool Conference)
        {
            List<Student> list = new List<Student>();
            foreach (var student in tree)
            {
                if (student.AverageMark >= AverageMark && student.Conference == Conference)
                {
                    list.Add(student);
                }
            }
            return list;
        }
        public static void DeleteStudents(this BinaryTree tree, double AverageMark, bool Conference)
        {
            List<Student> toDelete = FindStudents(tree, AverageMark, Conference);
            foreach (var student in toDelete)
            {
                tree.Delete(student);
            }
        }
    }
}
