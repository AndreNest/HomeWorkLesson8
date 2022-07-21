// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine("Введите кол-во строк и столбцов массива: "); int arrowSize = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента: "); int maxNumb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значчение элемента: "); int minNumb = int.Parse(Console.ReadLine());
Console.WriteLine("Массив со случайными значениями: ");

int[,,] array = GetArray(arrowSize, maxNumb, minNumb);
int[,,] GetArray(int arrowSize, int maxNumb, int minNumb)
{
    int[,,] array = new int[arrowSize, arrowSize,arrowSize];
    for (int i = 0; i < arrowSize; i++)
    {
        for (int j = 0; j < arrowSize; j++)
        {
            for (int n = 0; n < arrowSize; n++)
            {
                array[i,j,n] = new Random().Next(minNumb, maxNumb+1);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(2); n++)
            {
                Console.Write($"{array[i,j,n]}({i},{j},{n}) " );
            }
            Console.WriteLine();
        }
        
    }
     

}

PrintArray(array);