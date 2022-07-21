// // Задача 54: Задайте двумерный массив. Напишите программу, 
// // которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Clear();
Console.WriteLine("Введите кол-во строк: "); int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: "); int colomns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента: "); int maxNumb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значчение элемента: "); int minNumb = int.Parse(Console.ReadLine());
Console.WriteLine("Массив со случайными значениями: ");
int[,] array = GenerateArray(rows, colomns, maxNumb, minNumb);
PrintArray(array);
Console.WriteLine("Отсортирован по строкам: ");
int[] row = new int[colomns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
            row[j] = array[i, j];
        SortMaxMin(row);
        Insert(true, i, row, array);
    }
PrintArray(array);
int[,] GenerateArray(int rows, int colomns, int maxNumb, int minNumb)
{
    int[,] array = new int[rows, colomns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            array[i, j] = new Random().Next(minNumb, maxNumb + 1);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
void SortMaxMin(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
        for (int j = 0; j < inArray.Length - i - 1; j++)
        {
            if (inArray[j] < inArray[j + 1])
            {
                int temp = inArray[j];
                inArray[j] = inArray[j + 1];
                inArray[j + 1] = temp;
            }
        }
}
void Insert(bool isRow, int dim, int[] source, int[,] dest)
{
    for (int k = 0; k < source.Length; k++)
    {
        if (isRow)
            dest[dim, k] = source[k];
        else
            dest[k, dim] = source[k];
    }
}