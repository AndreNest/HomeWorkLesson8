// Задача 62. Заполните спирально массив 4 на 4.
Console.Clear();
int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;//  2-3-4 -5                                                0  0  1 2 3 
int i = 0;   // 1                                                        0  1  2 3 4
int j = 0;  //  1-2 -3                                                   1
while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))      
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}
void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($" {array[i,j]}" +"\t");
    }

    Console.WriteLine();
  }
}
WriteArray(sqareMatrix);