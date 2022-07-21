// Задача 56 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите кол-во строк: "); int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: "); int colomns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента: "); int maxNumb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значчение элемента: "); int minNumb = int.Parse(Console.ReadLine());
Console.WriteLine("Массив со случайными значениями: ");
int[,] array = NewArray(rows, colomns, maxNumb, minNumb);
PrintArray(array);
Console.WriteLine("---------------------------------");
SumArrows(array);
int[,] NewArray(int rows, int colomns, int maxNumb, int minNumb)
{
    int[,] newArray = new int[rows, colomns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            newArray[i, j] = new Random().Next(minNumb, maxNumb + 1);
        }
    }
    return newArray;
}

void PrintArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write(newArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void SumArrows(int[,] newArray)
{
    int sumArrows = int.MaxValue;
    int indexArrows = -1;
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            sum += newArray[i, j];
        }
        if (sum < sumArrows)
        {
            sumArrows = sum;
            indexArrows = i + 1;
        }

    }
    Console.WriteLine($"Строка с наименьшой суммой элементов = {indexArrows} и ее сумма равна = {sumArrows}");
}
