using System;

class Calculator
{
    static void Main(string[] args)
    {
        bool continueCalculating = true;

        while (continueCalculating)
        {
            try
            {
            
                Console.Write("Введите первое число: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

              
                Console.Write("Введите второе число: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                
                Console.Write("Выберите операцию (+, -, *, :): ");
                char operation = Console.ReadKey().KeyChar;
                Console.WriteLine(); 

                double result = 0;
                bool isValidOperation = true;

            
                switch (operation)
                {
                    case '+':
                        result = Add(num1, num2);
                        break;
                    case '-':
                        result = Subtract(num1, num2);
                        break;
                    case '*':
                        result = Multiply(num1, num2);
                        break;
                    case ':':
                        result = Divide(num1, num2);
                        break;
                    default:
                        isValidOperation = false;
                        Console.WriteLine("Ошибка: Неверная операция!");
                        break;
                }

               
                if (isValidOperation)
                {
                    Console.WriteLine($"Результат: {num1} {operation} {num2} = {result}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введено некорректное число!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: Деление на ноль невозможно!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Console.WriteLine("\nХотите выполнить еще одно вычисление? (y/n)");
            char response = Console.ReadKey().KeyChar;
            Console.WriteLine(); 

            if (response != 'y' && response != 'Y' && response != 'н' && response != 'Н')
            {
                continueCalculating = false;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

  
    static double Add(double a, double b)
    {
        return a + b;
    }

   
    static double Subtract(double a, double b)
    {
        return a - b;
    }

    
    static double Multiply(double a, double b)
    {
        return a * b;
    }

    
    static double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException();
        }
        return a / b;
    }
}
