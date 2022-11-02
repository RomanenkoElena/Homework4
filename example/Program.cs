// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

int numberN = new Random().Next(1,10);

int[] CreateAndFill(int count)
{
  int[] array = new int[count];

  for (int i = 0; i < count; i++)
  {
    array[i] = Random.Shared.Next(1, 10);
  }
  return array;
}