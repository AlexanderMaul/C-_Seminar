// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

Console.WriteLine("Введите первое целое число и нажмите Enter \nВведите второе целое число и нажмите Enter ");
int num_A = Convert.ToInt32(Console.ReadLine());
int num_B = Convert.ToInt32(Console.ReadLine());
if(num_A / num_B == num_B)
{
    Console.WriteLine($"Число {num_A} является квадратом числа {num_B}");
}
else
{
    Console.WriteLine($"Число {num_A} не является квадратом числа {num_B}");
}

