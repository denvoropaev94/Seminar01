void ChecksMultipleNumber(int num){

    if ((num%7==0)&(num%23==0))
    {
        Console.WriteLine("Число кратно 7 и 23 Ура!!!");
    } 
    else
    {
        Console.WriteLine("Число не кратно 7 и 23");
    }
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
ChecksMultipleNumber(number);