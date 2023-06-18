using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер функции (от 1 до 20):");
        int functionNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение x:");
        double x = double.Parse(Console.ReadLine());

        double result = CalculateFunction(functionNumber, x);

        Console.WriteLine("Результат: " + result);
    }

    static double CalculateFunction(int functionNumber, double x)
    {
        double result = 0;

        switch (functionNumber)
        {
            case 1:
                result = 3 * Math.Sin(x + 2);
                break;
            case 2:
                result = 5 * Math.Cos(2 * x);
                break;
            case 3:
                result = Math.Sin(x) + Math.Cos(x);
                break;
            case 4:
                result = 2 * Math.Sin(x) + 3 * Math.Cos(x);
                break;
            case 5:
                result = (Math.Sin(x) + Math.Cos(x)) / 2;
                break;
            case 6:
                result = Math.Sin(x) - 2 * Math.Cos(x);
                break;
            case 7:
                result = 5 * Math.Sin(x) - 7 * Math.Cos(x);
                break;
            case 8:
                result = (Math.Sin(x) - Math.Cos(x)) / 5;
                break;
            case 9:
                result = 4 * Math.Sin(x) * 5 * Math.Cos(x);
                break;
            case 10:
                result = 8 * Math.Sin(2 * x) - Math.Cos(2 * x);
                break;
            case 11:
                result = 8 * Math.Sin(2 * x) - Math.Cos(2 * x);
                break;
            case 12:
                result = 4 * Math.Sin(x) * 5 * Math.Cos(x);
                break;
            case 13:
                result = Math.Sin(x) + Math.Cos(x);
                break;
            case 14:
                result = 2 * Math.Sin(x) + 3 * Math.Cos(x);
                break;
            case 15:
                result = (Math.Sin(x) - Math.Cos(x)) / 5;
                break;
            case 16:
                result = Math.Sin(x) - 2 * Math.Cos(x);
                break;
            case 17:
                result = 5 * Math.Sin(x) - 7 * Math.Cos(x);
                break;
            case 18:
                result = (Math.Sin(x) + Math.Cos(x)) / 2;
                break;
            case 19:
                result = 5 * Math.Cos(2 * x);
                break;
            case 20:
                result = 3 * Math.Sin(x + 2);
                break;
            default:
                Console.WriteLine("Некорректный номер функции.");
                break;
        }

        return result;
    }
}
