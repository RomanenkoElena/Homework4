// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в этом числе.

int numberN = new Random().Next(1,10000);
Console.WriteLine($"Ввод числа {numberN}");
int sum = 0;
int digit = 0;

while (numberN > 0)
{
    digit = numberN % 10;
    sum = sum + digit;
    numberN = numberN /= 10;
}

Console.WriteLine($"Сумма цифр в числе равна {sum}");
