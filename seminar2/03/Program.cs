/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число
кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление*/
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int ostatok = Ostatok(number2, number1);
int Ostatok(int number2, int number1)
{
    ostatok = number2 % number1;
    return ostatok;
}

if (number2 % number1 == 0)
{
    Console.WriteLine("Число кратно");
}
else
{
    Console.WriteLine("Число некратно. Остаток от деления: " + ostatok);
}

