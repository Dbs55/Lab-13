
// void PrintHeader()
// {

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

// double CalculateAverageGrade(int[] grades)
// {
//     int sum = 0;
//     foreach (int grade in grades)
//     {
//         sum += grade;
//     }
//     return (double)sum / grades.Length;
// }

// int CountFives(int[] grades)
// {
//     int count = 0;
//     foreach (int grade in grades)
//     {
//         if (grade == 5) count++;
//     }
//     return count;
// }

// int[] grades = { 4, 5, 3, 5, 4 };
// double average = CalculateAverageGrade(grades);
// int fives = CountFives(grades);

// System.Console.WriteLine($"{average}, {fives}");


// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine(Add(2, 3));
//         Console.WriteLine(Add(2.5, 3.5));
//         Console.WriteLine(Add(2, 3, 4));
//     }

//     static int Add(int a, int b)
//     {
//         return a + b;
//     }

//     static double Add(double a, double b)
//     {
//         return a + b;
//     }

//     static int Add(int a, int b, int c)
//     {
//         return a + b + c;
//     }
// }
// Б
// void PrintPerson(string name, int age)
// {
//     Console.WriteLine($"Человек: {name}, возраст: {age}");
// }
// PrintPerson("Арина", 23);
// PrintPerson("Глеб", 17);
// PrintPerson("Савелий", 45);

//Г

// int FindMax(int[] numbers)
// {
//     int max = numbers[0];
//     foreach (int number in numbers)
//     {
//         if (number > max) max = number;
//     }
//     return max;
// }

bool ContainsValue(int[] numbers, int target)
{
    foreach (int n in numbers)
    {

        if (n == target) return true;
    }
    return false;
}
bool boolIsPalindrome(string word){

    string lower = word.ToLower();
    string reverse = "";

    for (int i = lower.Length - 1; i >= 0; i--)
    {
        reverse += lower[i];
    }
    return lower == reverse;
}
