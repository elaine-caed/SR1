using System;

namespace EX8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] AS;
            int count;
            string str;
            int n_occurs;
            Console.WriteLine(" Enter string:");
            str = Console.ReadLine();
            Console.Write(" count = ");
            count = Convert.ToInt32(Console.ReadLine());
            if (count <= 0)
{
                Console.WriteLine(" Error.The value of count is incorrect.");
                Console.ReadLine();
                return;
            }
            AS = new string[count];
            Console.WriteLine(" Enter the array AS:");
            for (int i = 0; i < AS.Length; i++)
{
                Console.Write(" AS[{0}] = ", i);
                AS[i] = Console.ReadLine();
            }
            n_occurs = 0;
            for (int i = 0; i < AS.Length; i++)
                if (str == AS[i])
                    n_occurs++;
            Console.WriteLine(" n_occurs = {0} ", n_occurs);
            Console.ReadKey();
        }
    }
}
