void ImputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
int[,] matrix = new int[5, 5];
int[] matrix1 = new int[matrix.GetLength(0)];

void SearchMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        matrix1[i] = sum;
    }
}

void SearchMinMatrix(int[] matrix1)
{
int min = matrix1[0];
int strings = 0;
    for (int i = 0; i < matrix1.Length; i++)
    {
        if (min > matrix1[i])
        {
            min = matrix1[i];
            strings = i;
        }
    }
    Console.Write($"Минимальная сумма в страке: {strings + 1}");
}
Console.Clear();
ImputMatrix(matrix);
PrintMatrix(matrix);
SearchMatrix(matrix);
SearchMinMatrix(matrix1);

