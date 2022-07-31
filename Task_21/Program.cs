// 21. Напишите программу, которая принимает на вхож координаты двух точек и находит расстояние между ними в 2D пространстве

Console.WriteLine("Программа нахождения между точками А и В");
Console.WriteLine("Введите координаты точки А");
Console.Write("Введите координату Х: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
Console.Write("Введите координату X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Dist (int x1c, int y1c, int x2c, int y2c)
{
    int cat1 = 0;
    int cat2 = 0;
    double result = 0.0;

    cat1 = Math.Abs(x1c) - Math.Abs(x2c);
    cat2 = Math.Abs(y1c) - Math.Abs(y2c);
    result = Math.Sqrt(cat1 * cat1 + cat2 * cat2);
    return Math.Round(result,2);
}

double result = Dist(x1, y1, x2, y2);
Console.WriteLine($"Растояние между точками A и B: {result}");
