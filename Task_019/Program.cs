// Задача 19:

// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Enter five-digit number, PLEASE");
string? num = Console.ReadLine();
System.Console.WriteLine("Is this number a palindrome?");
if (num!.Length < 5 || num!.Length > 5) 
{
    System.Console.WriteLine("Number you have just entered is NOT a five-digit.");
}
else if (num![0] == num![4] && num![1] == num![3])
{
    System.Console.WriteLine("YES, this number is a palindrome!");
}
else 
{
    System.Console.WriteLine("NO, it's not.");
}


