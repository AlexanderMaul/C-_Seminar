// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа

int rndNum = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трёхзначное число => {rndNum}");

// С использованием метода
int delNum (int num)
{
    return (num / 100) * 10 + num % 10;
}
int result = delNum(rndNum);
Console.WriteLine($"Пполучаемое двухзначное число => {result}");



// Обычное решение
// int rndNum = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное трёхзначное число => {rndNum}");
// int result = ((rndNum / 100) * 10) + (rndNum % 10);
// Console.WriteLine($"После удаления второй цифры из случайного трёхзначного числа {rndNum} получаем {result}");

