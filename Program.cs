//Напишите программу, которая заполнит спирально массив 4 на 4.

int length = 4;
int[,] array = new int[length, length];
int num = 1;
int i = 0;
int j = 0;
while (num <= length * length)
{
    array[i, j] = num;
    if (i <= j + 1 && i + j < length - 1)
        j++;
    else if (i < j && i + j >= length - 1)
        i++;
    else if (i >= j && i + j > length - 1)
        j--;
    else
        i--;
    num++;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
PrintArray(nums);