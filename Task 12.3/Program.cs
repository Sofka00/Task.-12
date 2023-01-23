using System;

namespace Task_12._3
{
    internal class Program
    { //3) Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            while(num !=0)
            {
                int tmp = num % 10;

                if (tmp % 2 > 0)
                {
                    Console.WriteLine(tmp);
                }
                num /= 10;
            }
        }
    }
}
