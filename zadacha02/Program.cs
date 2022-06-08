//В двумерном массиве целых чисел.
// Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
Console.Clear();

void FillMatrix( int[,] matrix) 
{
    for ( int  i = 0; i < matrix.GetLength(0); i++)
    {
        for ( int j = 0; j < matrix.GetLength(1) ; j++)
        {
            matrix[i, j] = new Random().Next(1,10); 
        }
    
    }
}

void PrintMatrix(int [,] matrix) 
{
    for ( int  i = 0; i < matrix.GetLength(0); i++)
    {
        for ( int j = 0; j < matrix.GetLength(1) ; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}

int[,] matrix = new int[5, 5];

FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

int x = 0;
int y = 0;
int min = matrix[0, 0];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if  (matrix[i, j] < min)
        {
            min = matrix[i, j];
            x = i;
            y = j;
        }
    }
}
Console.WriteLine("Наименьший элемент: " + min);

Console.WriteLine("Вывод преобразованной матрицы");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        {
            if ((i == x) || (j == y))
                continue;
            else
                Console.Write(matrix[i, j] + " ");
        }
    }
    Console.WriteLine();
}
