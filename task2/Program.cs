// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int number = new Random().Next (100, 1000);
System.Console.WriteLine(number);

System.Console.Write("Число без второй цифры: " + number / 100);
System.Console.Write( + number % 10);




