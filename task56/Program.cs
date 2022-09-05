/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка*/

int [,] FillMatrix(int rowsCount, int columnsCount, int leftRange=-10, int rightRange=10)
{
    int[,] matrix=new int[rowsCount, columnsCount];
    Random rand=new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j]=rand.Next(leftRange,rightRange+1);
        }
    }
    return matrix;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           Console.Write(matrix[i,j]+ "  ");
        }
        Console.WriteLine();
    }
}

Console.Write ("Введиет колличество строк m ");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write ("Введиет колличество столбцов n ");
int n=Convert.ToInt32(Console.ReadLine());
int[,] matrix=FillMatrix(m,n);
PrintMatrix(matrix);
Console.WriteLine();

int [] sumLine = new int[m];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum=0;
  for (int j = 0; j < matrix.GetLength(1); j++)  
     {
        sum = sum + matrix[i,j];
        sumLine[i] = sum;
     } 
 Console.WriteLine($"Сумма {i} строки  {sumLine[i]}");
}

int min = sumLine[0];
int number=0;
for (int i = 0; i < sumLine.Length; i++)
{
    if (min > sumLine[i])
{
    min = sumLine[i];
    number = i;
}
}
Console.WriteLine($"Наименьшая сумма в строке {number}");