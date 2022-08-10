/*
Напишите программу, которая выводит случайное число из отрезка [10,99]
и показывает наибольшее число.
12>2, 78>8
*/

 void GetMaxNumberRandomValue()
 {
 int randomValue = new Random().Next(10,100);
 Console.WriteLine($"RandomValue - {randomValue}");

 int lastNumber = randomValue % 10;
 int firstNumber = randomValue/10;
 int max = firstNumber;

 if (lastNumber > max){
    max = lastNumber;
 } 
 if (lastNumber == firstNumber){
     Console.WriteLine("Цифры равны!!!");
 }
 Console.WriteLine($"FirstNumber - {firstNumber}");
 Console.WriteLine($"LastNumber - {lastNumber}");
 Console.WriteLine($"Maximalnoe - {max}");
 }

GetMaxNumberRandomValue();