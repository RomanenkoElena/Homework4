// Напишите метод, который принимает на вход два числа (А и В) и возводит число А в целую степень В.

int numA = new Random().Next(1, 10);
int numB = new Random().Next(1, 10);
Console.WriteLine($"Ввод чисел: A - {numA}, B - {numB}");
Step(numA, numB);

void Step(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result = result * numA;
    }

    Console.WriteLine($"Результат возведения числа {numA} в степень {numB} равен {result}");
}


