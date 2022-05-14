/*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.*/

int a = Vvod("A");
int b = Vvod("B");
int c = Vvod("C");
if (a>b+c||b>a+c||c>a+b)
{
    Console.WriteLine("Такой треугольник существовать не может");
}
else Console.WriteLine("Такой треугольник может существовать");

int Vvod(string sideTriangle)
{
    Console.Write($"Введите сторону треугольника {sideTriangle}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

