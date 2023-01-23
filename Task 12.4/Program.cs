using System;


namespace Task_12._4
{ //4) Пользователь вводит 1 число. Найти число, которое является зеркальным отображением
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            while (num1>0)
            {
                int tmp = num1 % 10; 
                num1 = num1 / 10;
                x = x * 10; 
                x = x + tmp;
               
            }
            Console.WriteLine(x);
        }
    }
}
