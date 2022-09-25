// 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
 
Console.Write("Введите пятизначное число:");
int fiveDigitNumber = Convert.ToInt32(Console.ReadLine());
int numberLength = fiveDigitNumber.ToString().Length;

if (numberLength == 5)
{
    if (fiveDigitNumber/10000 == fiveDigitNumber%10 || fiveDigitNumber/1000 == fiveDigitNumber%100)
    {
        Console.Write(" - полиндром");   
    }
    else 
    {
        Console.Write(" - не полиндром");
    }
}
else
{
    Console.WriteLine("Ошибка! Вы ввели не пятизначное число");
}
