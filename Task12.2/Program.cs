using System;

namespace Task12._2
{
    internal class Program
    { //2) Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int nod = 1;
            while (num1 != 0 && num2 != 0)
            {
                if (num1 > num2)
                {
                    num1 %= num2;
                }
                else
                {
                    num2 %= num1;
                }
                nod = num1 + num2;

            }
            Console.WriteLine(nod);
        }
    }
}
