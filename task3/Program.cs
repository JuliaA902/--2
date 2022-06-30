// Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.
System.Console.Write("Дано число: ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);

{
if (numberInt < 100) Console.WriteLine ("Третьей цифры нет");

{
    while (numberInt > 999)
    {
        numberInt = numberInt /10;
    }
    numberInt = numberInt %100;
    numberInt = numberInt %10;
}
Console.WriteLine("Третья цифра числа является: " + numberInt);

}





