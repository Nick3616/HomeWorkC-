void ImputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
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
int[,] matrix = new int[4, 4];
int[,] matrix1 = new int[4, 4];
int[,] rez = new int[4, 4];
int sum = 0;

void Prozmatrix(int[,] rez)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int per = (matrix[i, j] * matrix1[j, k]);
                sum += per;
            }
            rez[i, k] = sum;
            sum = 0;
        }
    }
}
Console.Clear();
ImputMatrix(matrix);
ImputMatrix(matrix1);
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix1);
Console.WriteLine();
Prozmatrix(rez);
PrintMatrix(rez);


