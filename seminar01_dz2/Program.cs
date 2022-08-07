Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b)
{
    Console.Write("a>b, max = ");
    Console.Write(a);
}
else
{
    Console.Write("b>a, max = ");
    Console.Write(b);
}