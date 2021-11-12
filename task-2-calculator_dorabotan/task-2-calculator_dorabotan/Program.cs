using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Введите число, операцию и второе число через Enter");

                try
                {
                    Console.WriteLine("Ответ: " + Calculate(Convert.ToDouble(Console.ReadLine()), Convert.ToChar(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели недопустимую операцию, попробуйте ещё раз!");
                    Console.ReadLine();
                    continue;
                }
                catch (Exception)
                {
                    Console.WriteLine("Вы ввели не число, попробуйте ещё раз!");
                    Console.ReadLine();
                    continue;
                }

            }
        }
        static double Calculate(double x, char operation, double y)
        {
            switch (operation)
            {
                case '+':
                    return Add(x, y);

                case '-':
                    return Subtract(x, y);

                case '*':
                    return Multiply(x, y);

                case '/':
                    return Divide(x, y);

                case '^':
                    return Power(x, y);
                case '=':
                    return Sqrt(x, y);

                default:
                    throw new FormatException();
            }
        }
        static double Add(double x, double y)
        {
            return x + y;
        }
        static double Subtract(double x, double y)
        {
            return x - y;
        }

        static double Power(double x, double y)
        {
            return Math.Pow(x, y);
        }

        static double Divide(double x, double y)
        {
            
            if (y == 0)
            {
                throw new DivideByZeroException("Деление на ноль");
            }
            else
            {
                return x / y;
            }

        }
        static double Multiply(double x, double y)
        {
            return x * y;
        }

        static double Sqrt(double x, double y)
        {
            if (y == 0)
            {
                //throw new Exception("Деление на ноль");
                return Math.Pow(x, 1 / y);
            }
            else
            {
                return Math.Pow(x, 1 / y);
            }

        }



    }
}
