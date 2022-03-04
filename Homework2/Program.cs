using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача №1
            // Посчитать сумму всех трех цифр трехзначного числа, заданного константой (const).
            // Вывести сумму на печать.

            /*Console.Write("Введите первое трёхзначное число: ");
            int firstDigit = int.Parse(Console.ReadLine());

            int c = firstDigit % 10;

            int b = (firstDigit / 10) % 10;

            int a = firstDigit / 100;

            int sum = a + b + c;

            Console.WriteLine($"Сумма трёх чисел равна: {sum}");*/


            // Задача№2
            /*Console.WriteLine("Введите первый координат: ");
            int x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второй координат: ");
            int y1 = int.Parse(Console.ReadLine());

            bool a = true;

            int r = 10;

            double area = Math.PI * Math.Pow(r,2);

            if (x1 < area && y1 < area ) 
            {
                Console.WriteLine(a);
            }

            else 
                Console.WriteLine("false");*/


            //Задача №3
            // Пользователь вводить трехзначное число.
            // Записать логическое условие, которые будет истинным тогда и только тогда,
            // когда его средняя цифра меньше
            // или равна (<=) первой (левой) и одновременно строго больше (>) последней (правой).

            /*Console.Write("Введите первое трёхзначное число: ");
            int firstDigit = int.Parse(Console.ReadLine());

            int c = firstDigit % 10;

            int b = (firstDigit / 10) % 10;

            int a = firstDigit / 100;

            if (a >= b && b > c)
            {
                Console.WriteLine($"{firstDigit} (true)");
            }
            else
                Console.WriteLine($"{firstDigit} (false)");*/

            // Задачи №4 
            // Ввести целое трехзначное число.
            // Поменять местами его первую и последнюю цифры.
            // Собрать новое число в новой переменной!

            /*Console.Write("Введите первое трёхзначное число: ");
            int firstNumber = int.Parse(Console.ReadLine());

            int c = firstDigit % 10;

            int b = (firstDigit / 10) % 10;

            int a = firstDigit / 100;

            int result = c * 100 + b * 10 + a;

            Console.WriteLine(result);

            //Console.WriteLine($"{c}{b}{a}"); // Это без выделения переменной*/


            // Задача №5
            // Записать логическое условие, которое проверит,
            // что в double числе нулевая дробная часть.

            /*Console.WriteLine("Введите существенное число: ");
            
            double first = double.Parse(Console.ReadLine());

            int integer = (int)first;             

            double fractionalNumber = first - integer;

            if (first == integer)
            {
                Console.WriteLine("true");
            }
            else
                Console.WriteLine("false");*/







        }
    }
}
