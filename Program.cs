﻿// See https://aka.ms/new-console-template for more information
using ASDLab3;
void PrintTree(BinaryTree tree)
{
    Console.WriteLine($"{"Surname", -15} {"Card ID", -10}{"Average Mark", -15}{"Actions in conferences",-10}");
    foreach (Student student in tree)
    {
        Console.WriteLine($"{student.Surname, -15} {student.StudentID, -10} {student.AverageMark, -15}{student.Conference, -10}");
    }
}





BinaryTree tree = new BinaryTree(new StudentComparer());
tree.Add(new Student("Ivanenko", 3, 3, true));
tree.Add(new Student("Shevchenko", 5, 3.8, false));
tree.Add(new Student("Kovalenko", 12, 4.5, true));
tree.Add(new Student("Bondarenko", 9, 4.5, false));
tree.Add(new Student("Tkachenko", 7, 4.5, false));
tree.Add(new Student("Melnyk", 8, 4, true));
tree.Add(new Student("Krivenko", 15, 4.5, false));
tree.Add(new Student("Petryk", 4, 4.5, true));
tree.Add(new Student("Zhuk", 1, 4.8, false));
tree.Add(new Student("Horobets", 6, 4.2, false));
tree.Add(new Student("Rudenko", 13, 4.4, false));

PrintTree(tree);

Console.WriteLine("\nПiсля видалення елементiв:\n");

tree.DeleteElements();

PrintTree(tree);


