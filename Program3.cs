using System;

namespace EX3
{
    class Program
    {
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
        static int[] InsertionSort(int[] array)
            {
                for (var i = 1; i < array.Length; i++)
                {
                    var key = array[i];
                    var j = i;
                    while ((j > 1) && (array[j - 1] > key))
                    {
                        Swap(ref array[j-1], ref array[j]);
                        j--;
                    }
                    array[j] = key;
                }
            return array;
            }
        static void Main(string[] args)
        {
            Console.WriteLine(" Сортування включенням ");
            Console.Write(" Введіть елементи масиву: ");
            var parts = Console.ReadLine().Split(new[] { " ", ",", " ; "}, StringSplitOptions.RemoveEmptyEntries);
            var array = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                array[i] = Convert.ToInt32(parts[i]);
            }
            Console.WriteLine("Впорядкований масив: {0} ", string.Join(", ", InsertionSort(array)));
            Console.ReadLine();
        }
    }
}
