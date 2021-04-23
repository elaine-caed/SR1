using System;

namespace EX7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] AS; // масив рядків
            int count; // к-сть елементів у масиві
            string str; // рядок, який шукається
                        // 2. Ввести к-сть рядків
            Console.Write(" count = ");
            count = Int32.Parse(Console.ReadLine());
            // 3. Перевірка, чи значення count є коректне
            if (count <= 0)
{
                Console.WriteLine(" Error.The value of count is incorrect.");
                Console.ReadKey();
                return;
            }
            // 4. Виділити пам&#39;ять для масиву з count рядків
            AS = new string[count];
            // 5. Ввести дані масиву з клавіатури
            Console.WriteLine(" Enter array:");
            for (int i = 0; i < AS.Length; i++)
{
                Console.Write(" AS[{0}] = ", i);
                AS[i] = Console.ReadLine();
            }
            // 6. Ввести рядок символів
            Console.Write(" Enter string: ");
            str = Console.ReadLine();
            // 7. Пошук рядка в масиві рядків
            bool f_is = false; // прапорець, що сигналізує наявність рядка в масиві
            int index = -1; // позиція рядка в масиві

            for (int i = 0; i < AS.Length - 1; i++)
if (str == AS[i])
            {
                f_is = true;
                index = i;
            }
            // 8. Виведення результату
            if (f_is)
            {
                Console.WriteLine(" String \"{0}\" is in the array.", str);
                Console.WriteLine(" Position is {0} ", index);
            }
            else
            {
                Console.WriteLine(" String \"{0}\" is not in the array.", str);
            }
            Console.ReadKey();
        }
    }
}
