// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.WriteLine("Программа проверки двух чисел на кратность");
Console.WriteLine("Введите первое число и нажмите Enter \nВведите второе число и нажмите Enter");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());

// С использованием метода
int remainder = num1 % num2;

bool Metod(int x, int y)
{
    if (x % y == 0) return true;
    return false;
}
bool met = Metod(num1, num2);
if (met == true)
{
    Console.WriteLine($"кратно");
}
else
    Console.WriteLine($"не кратно, остаток {remainder}");

    

// Обычное решение
// if (numA % numB == 0) Console.WriteLine($"Первоее число {numA} кратно второму числу {numB}");
// else if (numB > numA) Console.WriteLine($"Число {numA} не кратно числу {numB}. Остаток от деления 0");
// else Console.WriteLine($"Число {numA} не кратно числу {numB}. Остаток от деления {numA % numB}");

// Решение из семинара через bool - не совсем правильное
// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int remainder = num1 % num2;

// bool Metod(int num1, int num2)
// {
// if (num1 % num2 == 0) return true;
// return false;
// }
// bool met = Metod(num1, num2);
// string result = Metod == true ? "кратно" : "не кратно, остаток {remainder}";