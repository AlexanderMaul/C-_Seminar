// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X!=0 и Y!=0 и выдаёт номер плоскости в которой находится эта точка

Console.WriteLine("Программа нахождения координатной четверти для заданной точки с координатами X и Y");
Console.Write("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

// Простой способ
// if (x > 0 && y > 0) Console.WriteLine("Первая четверть");
// else if (x < 0 && y > 0) Console.WriteLine("Вторая четверть");
// else if (x < 0 && y < 0) Console.WriteLine("Третья четверть");
// else if (x > 0 && y < 0) Console.WriteLine("Четвёртая четверть");
// else Console.WriteLine("Введены некорректные координаты");


// С использованием метода
// string Quarter (int xc, int yc)
// {
//     string result = "";
//     if (x > 0 && y > 0) result = "Первая четверть";
//     else if (x < 0 && y > 0) result = "Вторая четверть";
//     else if (x < 0 && y < 0) result = "Третья четверть";
//     else if (x > 0 && y < 0) result = "Четвёртая четверть";
//     else result = "Введены некорректные координаты";
//     return result;
// }

// string result = Quarter(x, y);
// Console.WriteLine(result);



// Совершенствуем решение
string Quarter (int xc, int yc)
{
    if (x > 0 && y > 0) return "Первая четверть";
    if (x < 0 && y > 0) return "Вторая четверть";
    if (x < 0 && y < 0) return "Третья четверть";
    if (x > 0 && y < 0) return "Четвёртая четверть";
    return "Введены некорректные координаты";
}

string result = Quarter(x, y);
Console.WriteLine(result);
