// Напишите программу , которая выводит случайное трехзначное число и удаляет вторую цифру.
// 782>72

void GetThreedigitNumberRandomDeleteTwo(){
    Random random = new Random();
    int randomValue = random.Next(100,1000);
    Console.WriteLine(randomValue);

    int firstNumber = randomValue/100;
    int lastNumber = randomValue%10;
    Console.WriteLine($"{firstNumber}{lastNumber}");
}
GetThreedigitNumberRandomDeleteTwo();
GetThreedigitNumberRandomDeleteTwo();