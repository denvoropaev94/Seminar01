﻿void CheckIsItSquare(int num1, int num2)
{
    if ((num1 == num2 * num2) || (num2 == num1 * num1))
    {
        Console.WriteLine("Является квадратом");
    }
    else
    {
        Console.WriteLine("НЕТ!");
    }
}
Console.WriteLine("Введите 1 число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int number2 = Convert.ToInt32(Console.ReadLine());
CheckIsItSquare(number1,number2);
CheckIsItSquare(number1,number2);