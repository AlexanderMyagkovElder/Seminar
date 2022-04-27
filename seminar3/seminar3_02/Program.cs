/* Напишите программу, которая принимает на вход координаты 2х и находит 
расстояния между ними в 2D*/

int x1 = Vvod("x", "A");

int y1 = Vvod("y", "A");

int x2 = Vvod("x", "B");

int y2 = Vvod("y", "B");
double Katet(int a, int b)
{
    double katet = Math.Pow((b - a), 2);
    return katet;
}
double distance = Math.Sqrt(Katet(x1, x2) + Katet(y1, y2));
Console.WriteLine($"Расстояние между точками равно {Math.Round(distance)}");

int Vvod(string XY, string AB)
{
    Console.Write($"Введите координату {XY} точки {AB}: ");
    return Convert.ToInt32(Console.ReadLine());
}