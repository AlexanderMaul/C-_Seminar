// 18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти

Console.WriteLine("Программа нахождения диапазона для точки с координатами X и Y по заданной четверти");
Console.Write("Введите номер четверти: ");
int quar = Convert.ToInt32(Console.ReadLine());

// Обычный метод
// string Quarter (int quarc)
// {
//     if (quarc == 1) return "В первой четверти X>0 и Y>0";
//     if (quarc == 2) return "Во второй четверти X<0 и Y>0";
//     if (quarc == 3) return "В третьей четверти X<0 и Y<0";
//     if (quarc == 4) return "В четвёртой четверти X>0 и Y<0";
//     return "Такой четверти нет";
// }

// string result = Quarter(quar);
// Console.WriteLine(result);


// Метод switch
string Quarter (int quarc)
{
    switch (quarc)
    {
        case 1:
            return "В первой четверти X>0 и Y>0";
        case 2:
            return "Во второй четверти X<0 и Y>0";
        case 3:
            return "В третьей четверти X<0 и Y<0";
        case 4:
            return "В четвёртой четверти X>0 и Y<0";    
        default:
            return "Такой четверти нет";
    }
}

string result = Quarter(quar);
Console.WriteLine(result);
