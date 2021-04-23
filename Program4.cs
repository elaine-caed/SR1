using System;

namespace EX4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { " Sunday ", " Monday ", " Tuesday ", " Wednesday ", " Thirsday ", " Friday ", " Saturday "};
        for (int i = 0; i < daysOfWeek.Length; i++)
           Console.WriteLine("AS[{0}] = {1}", i, daysOfWeek[i]);
        Console.ReadKey();
        }
    }
}
