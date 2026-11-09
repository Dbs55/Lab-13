
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
// void PrintStudentCard(string name, int age, string numbergroup)
// {
//     System.Console.WriteLine($"Студент: {name}, Возраст:{age}");
// }
// PrintStudentCard("Егор", 18, "П-21");
// PrintStudentCard("Валерия", 17, "П-21");


// double CalculateScholarship(double baseAmount, double bonusPercent)
// {
//     return baseAmount + baseAmount * bonusPercent / 100;
// }

// bool IsEligibleForBonus(double averageGrade)
// {
//     return averageGrade >= 4.5;
// }
// double result = CalculateScholarship(2000, 15);
// Console.WriteLine(result);

// double averageGrade = 4.6;

// if (IsEligibleForBonus(averageGrade))
// {
//     Console.WriteLine($"Стипендия с надбавкой: {CalculateScholarship(2000, 15)}");
// }
// else
// {
//     Console.WriteLine($"Стипендия без надбавки: {CalculateScholarship(2000, 0)}");
// }

 double CalculateAverageGrade(int[] grades)
{
    int sum = 0;
    foreach (int grade in grades)
    {
        sum += grade;
    }
    return (double)sum / grades.Length;
}

int CountFives(int[] grades)
{
    int count = 0;
    foreach (int grade in grades)
    {
        if (grade == 5) count++;
    }
    return count;
}

int[] grades = { 4, 5, 3, 5, 4 };
double average = CalculateAverageGrade(grades);
int fives = CountFives(grades);

System.Console.WriteLine($"{average}, {fives}");