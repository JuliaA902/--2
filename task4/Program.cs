// Напишите программу, которая принимает на вход цифру, обозначающую день 
// недели, и проверяет, является ли этот день выходным.

int input(string message)
{
Console.Write(message);
string number = Console.ReadLine();
int numberInt = int.Parse(number);
return numberInt;
}

int numberInt = input("Введите цифру: ");

if (numberInt <1 || numberInt >7);
{
    Console.WriteLine("Данная цифра не является днем недели");
    Environment.Exit(0);
}

if  (numberInt == 6 || numberInt == 7)
   Console.WriteLine("Этот день является выходным днем недели"); 
else  Console.WriteLine("Данный день недели не выходной");
