using System;

namespace EX6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] AS; // масив рядків
            int count; // к-сть елементів у масиві
            string s; // додаткова змінна-рядок
                      // 2. Ввести к-сть рядків
            Console.Write(" count = ");

            count = Int32.Parse(Console.ReadLine());
            // 3. Виділити пам&#39;ять для масиву з count рядків
            AS = new string[count];
            // 4. Ввести дані масиву з клавіатури
            Console.WriteLine(" Enter array: ");
            for (int i = 0; i < AS.Length; i++)
            {
                Console.Write(" AS[{0}] = ", i);
                AS[i] = Console.ReadLine();
            }
            // 5. Сортування методом вставки
            for (int i = 0; i < AS.Length - 1; i++)
                for (int j = i; j >= 0; j--)
                    if (String.Compare(AS[j], AS[j + 1]) < 0) // функція Compare()
                    {
                        // поміняти значення місцями
                        s = AS[j];
                        AS[j] = AS[j + 1];
                        AS[j + 1] = s;
                    }
            // 6. Вивести масив AS
            Console.WriteLine(" Sorted array:");
            for (int i = 0; i < AS.Length; i++)
                Console.WriteLine(" AS[{0}] = {1}", i, AS[i]);
            Console.ReadKey();
        }
    }
}
