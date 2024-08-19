namespace Homework01
{
    internal class Program
    {
        static void AutoCalc(int num1, int num2, string operation)
        {
            int result = 0;

            if (operation == "+")
            {
                result = num1 + num2;
            }
            if (operation == "-")
            {
                result = num1 - num2;
            }
            if (operation == "/")
            {
                result = num1 / num2;
            }
            if (operation == "*")
            {
                result = num1 * num2;
            }

            Console.WriteLine($"Результат выполнения операции = {result}");
        }

        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                int number1 = int.Parse(args[0]);

                string operation = args[1];

                int number2 = int.Parse(args[2]);

                AutoCalc(number1, number2, operation);

            }
            else
            {
                Console.Write("Введите первое число: ");

                int number1 = int.Parse(Console.ReadLine()!);

                Console.Write("Введите нужную операцию (+, -, /, *): ");

                string operation = Console.ReadLine()!;

                Console.Write("Введите второе число: ");

                int number2 = int.Parse(Console.ReadLine()!);

                AutoCalc(number1, number2, operation);
            }
        }
    }
}