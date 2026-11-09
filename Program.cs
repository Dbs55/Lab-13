
// void PrintHeader() {
//     System.Console.WriteLine("^_^");
//     Console.WriteLine("Лабораторная работа №13");
//     System.Console.WriteLine("13.10.2009");
//     Console.WriteLine("0_0");
// }

// void PrintFooter()
// {
//     System.Console.WriteLine(">_<");
//     Console.WriteLine("конец программы");
//     Console.WriteLine("х_х");
// }

// PrintHeader();
// Console.WriteLine("Основная часть программы");
// PrintFooter();
void PrintStudentCard(string name, int age, string numbergroup)
{
    System.Console.WriteLine($"Студент: {name}, Возраст:{age}");
}
PrintStudentCard("Егор", 18, "П-21");
PrintStudentCard("Валерия", 17, "П-21");