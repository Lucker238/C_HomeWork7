// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] newArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
          result[i,j] = new Random().Next(-100,100);  
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

string findEllement(int y, int x, int[,] array)
{
    if(x > array.GetLength(0) || y > array.GetLength(1))
    {
        return "Введеные числа лежат за пределами массива";
    }
    else return Convert.ToString(array[x-1, y-1]);
}


System.Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите позицию по вертикали: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите позицию по горизонтали: ");
int y = Convert.ToInt32(Console.ReadLine());


int[,] array = newArray(m,n);
showArray(array);
System.Console.WriteLine();
System.Console.WriteLine(findEllement(y,x,array));

