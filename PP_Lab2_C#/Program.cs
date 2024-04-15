enum Day
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

enum DayTime
{
    Morning,
    Day,
    Evening,
    Night
}


class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер дня недели");
        int dayI = Convert.ToInt16(Console.ReadLine());
        if (dayI > 7 && dayI > 0) {
            Console.WriteLine("Неверно введен день недели");
        }
        else
        {
            Console.WriteLine("Введите время");
            int dayTimeI = Convert.ToInt16(Console.ReadLine());
            if (dayTimeI > 23 && dayTimeI > 0)
            {
                Console.WriteLine("Неверно введено время");
            }
            else
            {
                int dayTimeIndex = 0;
                if (dayTimeI > 7 && dayTimeI < 13)
                {
                } else if(dayTimeI > 12 && dayTimeI < 19)
                {
                    dayTimeIndex = 1;
                } else if (dayTimeI > 18 && dayTimeI < 24)
                {
                    dayTimeIndex = 2;
                }
                else
                {
                    dayTimeIndex = 3;
                }

                printDayTime((Day)(dayI-1), (DayTime)(dayTimeIndex));
            }
        }
        

        
        
        
    }

    static void printDayTime(Day day, DayTime dayTime)
    {
        Console.WriteLine($"Сейчас {day}, {dayTime}");
    }
}
