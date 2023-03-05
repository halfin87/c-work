// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int lastdigit = number % 10;
int fourdigit = (number / 10) % 10;
int seconddigit = (number / 1000) % 10;
int firstdigit = number / 10000;
if(firstdigit == lastdigit && seconddigit == fourdigit)
{
  Console.WriteLine("является палиндромом");
}
else Console.WriteLine("Не является палиндромом");