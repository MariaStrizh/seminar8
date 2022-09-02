/* Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
1, 2, 3
4, 6, 1
2, 1, 6

1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
В нашей исходной матрице встречаются элементы от 0 до 9*/

int [,] FillMatrix(int rowsCount, int columnsCount, int leftRange=0, int rightRange=9)
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
// Задача 57
void PrintRepeatofElements(int[,] matrix)
{
int[] repeat=new int[10];
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
         repeat[matrix[i,j]]++;
        }
    }
  for (int i = 0; i <repeat.Length; i++) 
  {
    if (repeat[i] > 0)
    Console.WriteLine($"Колличество повторений {i} = {repeat[i]}");
  } 
}
//Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку 
//и столбец, на пересечении которых расположен наименьший элемент массива.

int[,] DeletMinElement (int[,] matrix)
{
    int[,] newMatrix= new int[matrix.GetLength(0)-1,matrix.GetLength(1)-1];
    int min=matrix[0,0];
    int minRow=0;
    int minColomn=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
         if (matrix[i,j]< min)
         {
            min=matrix[i,j];
            minRow=i;
            minColomn=j;
         }
        }
    }
    int rowOffset=0;
    int ColomnOffset=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i==minRow)    rowOffset=rowOffset+1;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
         if (j==minColomn) ColomnOffset++;
         newMatrix[i,j]=matrix[i+rowOffset,j+ColomnOffset];
        }
        ColomnOffset=0;
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
int[,] newMatrix=DeletMinElement(matrix);
PrintMatrix(newMatrix);