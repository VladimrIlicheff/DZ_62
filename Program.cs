

int[,] matrix = InitMatrix(4, 4);
int GetNumber(string message)

{

    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[,] InitMatrix(int m, int n)
{
    int[,] resultMatrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultMatrix[i, j] = rnd.Next(0, 10);
        }
    }
    return resultMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}      ");
        }
        Console.WriteLine();
    }
}


Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("- - - - - - - - -");
Console.WriteLine();
//SumMinRow(matrix);
Console.WriteLine();

