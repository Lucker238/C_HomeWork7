// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] newArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
          result[i,j] = new Random().Next(-10,10);  
        }
    }
    return result;
}

void showArray(int[,] input)
{
    for (int i = 0; i < input.GetLength(0); i++)
    {
        for (int j = 0; j < input.GetLength(1); j++)
        {
            System.Console.Write($"{input[i,j]} ");   
        }
        System.Console.WriteLine();
    }
}

string findAverage(int[,] array)
{
    string result = "";
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j,i];
        }
        result += Convert.ToString(sum / array.GetLength(0)) + " ";   
    }
    return result;
}

System.Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = newArray(m,n);
showArray(array);
System.Console.WriteLine("Среднее арифметическое каждого столбца:");
System.Console.WriteLine(findAverage(array));