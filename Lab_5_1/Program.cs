using System;

namespace Lab_5_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            int k = 0;
            while (str.IndexOf(".", k) != -1)
            {
                k = str.IndexOf(".", k);
                str = str.Insert(k + 1, " ");
                k += 1;
            }
            Console.WriteLine(str);


        }
    }
}
