using System;

class ChildProgram
{
    static void Main(string[] args)
    {
        if (args.Length != 3)
        {
            Console.WriteLine("Неправильна кількість аргументів. Потрібно ввести два числа та операцію.");
            return;
        }

        int number1 = int.Parse(args[0]);
        int number2 = int.Parse(args[1]);
        string operation = args[2];

        int result = 0;

        switch (operation)
        {
            case "+":
                result = number1 + number2;
                break;
            case "-":
                result = number1 - number2;
                break;
            case "*":
                result = number1 * number2;
                break;
            case "/":
                result = number1 / number2;
                break;
            default:
                Console.WriteLine("Непідтримувана операція.");
                return;
        }

        Console.WriteLine($"Результат виконання: {result}");
        
        Console.WriteLine("Отримані аргументи:");
        foreach (string arg in args)
        {
            Console.WriteLine(arg);
        }

        Console.ReadKey();
    }
}