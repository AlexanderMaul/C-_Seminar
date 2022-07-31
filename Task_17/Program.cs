// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X!=0 и Y!=0 и выдаёт номер плоскости в которой находится эта точка

Console.WriteLine("Программа нахождения координатной четверти для заданной точки с координатами X и Y");
Console.WriteLine("Введите координату X и нажмите Enter");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y и нажмите Enter");
int y = Convert.ToInt32(Console.ReadLine());

// Простой метод
if (x > 0 && y > 0) Console.WriteLine("Первая четверть");
else if (x < 0 && y > 0) Console.WriteLine("Вторая четверть");
else if (x < 0 && y < 0) Console.WriteLine("Третья четверть");
else if (x > 0 && y < 0) Console.WriteLine("Четвёртая четверть");
else Console.WriteLine("Введены некорректные координаты");

