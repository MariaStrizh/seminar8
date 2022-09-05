/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.*/

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
int[,] matrix1=FillMatrix(m,n);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2=FillMatrix(m,n);
PrintMatrix(matrix2);

int[,] result = new int[m,n];
for (int i = 0; i < result.GetLength(0); i++)
{  
    for (int j = 0; j < result.GetLength(1); j++)
    {
    result[i,j]= matrix1[i,j]*matrix2[i,j];
    }
}
Console.WriteLine("Произведение матриц:");
PrintMatrix(result);