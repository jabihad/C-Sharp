using System;

public class Program
{
    enum WeekDays
    {
        Monday,        // 0
        Tuesday,       // 1
        Wednesday,     // 2
        Thursday = 6,  // 6
        Friday,        // 7
        Saturday,      // 8
        Sunday         // 9
    }
    public static void Main()
    {
        Console.WriteLine(WeekDays.Monday);         // Monday

        Console.WriteLine((int)WeekDays.Friday);    // 7
        Console.WriteLine((int)WeekDays.Saturday);  // 8
        Console.WriteLine((int)WeekDays.Sunday);    // 9
    }
}
