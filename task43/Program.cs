// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double InputNumber2(string message)

{
    double number;
    while (true)
    {
        System.Console.Write(message);
        if (!(double.TryParse(Console.ReadLine(), out number)))
        {
            System.Console.WriteLine("Введено некорректное число, попробуйте ещё раз.");
        }
        else break;
    }
    return number;
}


void CrossingPoint (double b1, double k1, double b2, double k2)
{
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;

x = Math.Round(x, 3);
y = Math.Round(y, 3);

Console.WriteLine($"Прямые пересекаются в точке: ({x};{y})");
}


double b1 = InputNumber2("Введите b1 : ");
double k1 = InputNumber2("Введите k1 : ");
double b2 = InputNumber2("Введите b2 : ");
double k2 = InputNumber2("Введите k2 : ");
CrossingPoint (b1,k1,b2,k2);






