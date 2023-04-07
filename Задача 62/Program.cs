
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
int num = 1;
int i = 0;
int j = 0;

while (num <= 4 * 4)
{
    matrix[i, j] = num;
    if (i <= j + 1 && i + j < 4 - 1)
        j++;
    else if (i < j && i + j >= 4 - 1)
        i++;
    else if (i >= j && i + j > 4 - 1)
        j--;
    else
        i--;
    num++;
}
PrintMatrix(matrix);