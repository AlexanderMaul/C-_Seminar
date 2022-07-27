// // 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// // Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.WriteLine("Программа проверки двух чисел на кратность");
Console.WriteLine("Введите первое число и нажмите Enter \nВведите второе число и нажмите Enter");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());

// Обычное решение
// if (numB % numA == 0) Console.WriteLine($"Второе число {numB} кратно первому числу {numA}");
// else if (numA > numB) Console.WriteLine($"Число {numA} не кратно числу {numB}, так как первое число больше второго");
// else Console.WriteLine($"Число {numB} не кратно числу {numA}. Остаток от деления {numB % numA}");


// С использованием метода
string krtn(int num1, int num2)
{
    if (num2 % num1 == 0) 
    {
        string result = $"Второе число {numB} кратно первому числу {numA}";
        return result;
    }
    else
    {
        if (num1 > num2) 
        {
            string result = $"Число {numA} не кратно числу {numB}, так как первое число больше второго";
            return result;
        }
        else
        {
            string result = $"Число {numB} не кратно числу {numA}. Остаток от деления {numB % numA}";
            return result;
        }
    }
}

Console.WriteLine(krtn(numA, numB));



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


