using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Сумма: " + Calculator.Add(a, b));
            Console.WriteLine("Разность: " + Calculator.Subtract(a, b));
        }
    }
}
