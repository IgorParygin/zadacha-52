// Задача 52: Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.


Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n}.");

int[,] array = new int[m, n];

CreateArray(array);

WriteArray(array);

Console.WriteLine();

void CreateArray(int[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().Next(-99,99);
    }
  }
}

void WriteArray (int[,] array){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        int Number = array[i, j];
        Console.Write(Number + " ");
      }
      Console.WriteLine();
  }
}

Console.Write($"\nCреднее арифметическое:\n");
for (int i = 0; i < n; i++)
{
  int arithmeticMean = 0;
  for (int j = 0; j < m; j++)
  {
    arithmeticMean += array[j, i];
  }
  arithmeticMean = arithmeticMean / m;
  Console.WriteLine($"столбца № {i+1} {arithmeticMean}");
}
