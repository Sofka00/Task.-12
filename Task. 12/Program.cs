using System;

namespace Task._12
{//1) Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            int b = 0;
            while (a != number)
            {
                if (number % a == 0)
                {
                    b = a;
                }

                a++;
            }
            Console.WriteLine(b);
        }




    }
}
