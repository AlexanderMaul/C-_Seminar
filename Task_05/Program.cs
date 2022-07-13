// 5. Написать программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int index = -num;

while (index <= num)
{
        Console.Write($"{index} ");
        index += 1;
}



