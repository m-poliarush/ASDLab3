// See https://aka.ms/new-console-template for more information
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
tree.Add(new Student("Poliarush", 3, 3, false));
tree.Add(new Student("Poliarush", 5, 5, false));
tree.Add(new Student("Poliarush", 12, 4.5, true));
tree.Add(new Student("Poliarush", 9, 4.5, false));
tree.Add(new Student("Poliarush", 7, 4.5, false));
tree.Add(new Student("Poliarush", 8, 4.5, false));
tree.Add(new Student("Poliarush", 15, 4.5, false));
tree.Add(new Student("Poliarush", 4, 4.5, true));
tree.Add(new Student("Poliarush", 1, 4.8, false));
tree.Add(new Student("Poliarush", 6, 4.2, false));
tree.Add(new Student("Poliarush", 13, 4.5, false));

PrintTree(tree);


tree.DeleteElements();

PrintTree(tree);


