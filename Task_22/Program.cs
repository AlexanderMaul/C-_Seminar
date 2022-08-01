// 22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N

Console.WriteLine("Программа нахождения квадратов для чисел от 1 до N");
Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());

// Простой метод
int index = 1;
int square = 0;
while (index <= num)
{       
    square = index * index;
    Console.WriteLine($"{index, 10} -> {square, 10}");
    index++;
}

// Массив из семинара
// int index = 1;
// int[] tableq = new int [num];

// while (index <= num)
// {
// tableq[index - 1] = index * index;
// index++;
// }

// Console.WriteLine ($"Таблица квадратов чисел от 1 до {num}: {String.Join(", ",tableq)}");






