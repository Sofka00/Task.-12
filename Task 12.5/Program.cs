using System;

namespace Task_12._5
{
    internal class Program
    { //5*) Пользователь вводит целое положительное число, которое является кубом числа N. Найдите число N методом половинного деления.
        static void Main(string[] args) // отрезок от n до num1 - c- середина отрезка 
        {
            int num1 = Convert.ToInt32(Console.ReadLine()); //с=(a+b)/2.
            int n = 0;
            int c = 0;
            int x = 0;

            while (Math.Pow (c,3) != num1)
            {

              //      n = num1 / num1 / num1;    

                if (n < x)
                {
                    c = (n + x) / 2;
                    c = x;
                }

                else if (Math.Pow(c, 3) < num1)
                {
                    c = n;
                    c = (c + n) / 2;
                  
                }
                Console.WriteLine(n);



            }
           
        } 
    }
}
