/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

void ShowsSecondDigit()
{
    Console.Write("Введи трёхзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    string stringNumber = Convert.ToString(number);
    Console.WriteLine("вторая цифра этого числа - " + stringNumber[1]);
}
ShowsSecondDigit();