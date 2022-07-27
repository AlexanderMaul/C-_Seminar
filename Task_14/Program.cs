// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Программа проверки кратности числа одновременно на 7 и на 23");
Console.WriteLine("Введите число и нажмите Enter");
int numA = Convert.ToInt32(Console.ReadLine());

string krtn(int num)
{
    if (num % 7 == 0 && num % 23 == 00) 
    {
        string result = "Да"; 
        return result;
    }
    else
    {
        string result = "Нет";
        return result;
    }
}

Console.WriteLine(krtn(numA));
