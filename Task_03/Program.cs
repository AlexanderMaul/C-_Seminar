// 3. Написать программу, которая будет выдавать название дня недели по задааному номеру

Console.WriteLine("Введите число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num == 1)
{
    Console.WriteLine("Понедельник - это первый день недели!");
}
else
{
    if(num == 2)
    {
        Console.WriteLine("Вторник - это второй день недели!");
    }
    else
    {
        if(num == 3)
        {
            Console.WriteLine("Среда - это третий день недели!");
        }
        else
        {
            if(num == 4)
            {
                Console.WriteLine("Четверг - это четвёртый день недели!");
            }
            else
            {
                if(num == 5)
                {
                    Console.WriteLine("Пятница - это пятый день недели!");
                }
                else
                {
                    if(num == 6)
                    {
                        Console.WriteLine("Суббота - это шестой день недели!");
                    }
                    else{
                        if(num == 7)
                        {
                            Console.WriteLine("Воскресенье - это седьмой день недели!");
                        }
                        else
                        {
                            Console.WriteLine("Какое большое число - в неделе всего семь дней;)");
                        }
                    }
                }
            }
        }
    }
}

