// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

void CreateArray (int[] numbers) // метод для создания массива
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers [index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray (int[] num) // метод для вывода массива на экран
{
    int count = num.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.WriteLine(num[pos]);
        pos++;
    }
}

int numberN = new Random().Next(1, 10); // Входные данные
Console.WriteLine($"Ввод числа {numberN}");

int[] array = new int[numberN]; // код программы
CreateArray (array);
PrintArray (array);