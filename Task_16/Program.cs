// 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого

Console.WriteLine("Программа проверки двух чисел - является ли одно квадратом другого");
Console.WriteLine("Введите первое число и нажмите Enter \nВведите второе число и нажмите Enter");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());

string sqr(int num1, int num2)
{
    if (num1 * num1 == num2 || num2 * num2 == num1) 
    {
        string result = $"{num1}, {num2} -> Да"; 
        return result;
    }
    else
    {
        string result = $"{num1}, {num2} -> Нет";
        return result;
    }
}

Console.WriteLine(sqr(numA, numB));
