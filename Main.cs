using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            char operation;
            char continueCalc;

            do
            {
                Console.Write("\nВведите первое число: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите второе число: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите операцию (+, -, *, /): ");
                operation = Console.ReadLine()[0];



                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        Console.WriteLine($"Результат: {num1} + {num2} = {result}");
                        break;
                    case '-':
                        result = num1 - num2;
                        Console.WriteLine($"Результат: {num1} - {num2} = {result}");
                        break;
                    case '*':
                        result = num1 * num2;
                        Console.WriteLine($"Результат: {num1} * {num2} = {result}");
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Результат: {num1} / {num2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: деление на ноль!");
                        }
                        break;
                    default:
                        Console.WriteLine("Некорректная операция");
                        break;
                }

                Console.Write("Хотите продолжить вычисления? (y/n):");
                continueCalc = Console.ReadLine()[0];

            } while (continueCalc == 'y' || continueCalc == 'Y');

        }
    }
}