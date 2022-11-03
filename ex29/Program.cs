// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

void FillArray(int[] numbers) // метод для заполнения массива
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] num) // метод для вывода массива на экран
{
    int length = num.Length;
    int pos = 0;
    while (pos < length)
    {
        Console.Write($"{num[pos]} ");
        pos++;
    }
}

int numberN = new Random().Next(1, 10); // Входные данные
Console.WriteLine($"Ввод числа {numberN}");
Console.WriteLine("Полученный массив:");

int[] array = new int[numberN]; // инициализация массива
FillArray(array);
PrintArray(array);