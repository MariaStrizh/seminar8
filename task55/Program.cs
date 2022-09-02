/*Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
 В случае, если это невозможно,
 программа должна вывести сообщение для пользователя.*/

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

int [,] ReverseArray (int[,] matrix)
{
    int[,] newMatrix= new int [matrix.GetLength(1),matrix.GetLength(0)];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
           newMatrix[i,j]=matrix[j,i] ;
        }
    }
    return newMatrix;
}

Console.Write ("Введиет m ");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write ("Введиет n ");
int n=Convert.ToInt32(Console.ReadLine());
int[,] matrix=FillMatrix(m,n);
PrintMatrix(matrix);
Console.WriteLine();
int[,] tmatrix=ReverseArray(matrix);
PrintMatrix(tmatrix);
