/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

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

void  SortArray (int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
          for (int n = 1; n < matrix.GetLength(1); n++)
          {
            if ( matrix[i,n]>matrix[i,n-1])
            {
                temp=matrix[i,n-1];
                matrix[i,n-1]=matrix[i,n];
                matrix[i,n]=temp;
            }
          }
        }
    } 
}

Console.Write ("Введиет m ");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write ("Введиет n ");
int n=Convert.ToInt32(Console.ReadLine());
int[,] matrix=FillMatrix(m,n);
PrintMatrix(matrix);
Console.WriteLine();
SortArray(matrix);
Console.WriteLine("Отсортированный массив:");
PrintMatrix(matrix);