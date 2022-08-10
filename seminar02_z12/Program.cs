void MultipleOfNumbers(int num1,int num2){
   
    if (num2%num1==0){
        Console.WriteLine("Число 2 кратно 1");
    }
    else{
        Console.WriteLine("Число 2 не кратно числу 1");
        Console.WriteLine($"Остаток от деления - {num2%num1}");
    }
}
     Console.Write("Введите первое число ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число ");
    int number2 = Convert.ToInt32(Console.ReadLine());

MultipleOfNumbers(number1,number2);