// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
//сколько раз встречается элемент входных данных.


int row = new Random().Next(3, 5);
int column = new Random().Next(3, 5);

int[,] matrix = new int[row, column];


void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int J = 0; J < matr.GetLength(1); J++)
        {
            matr[i, J] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int J = 0; J < matr.GetLength(1); J++)
        {
            Console.Write($"{matr[i, J]} ");
        }
        Console.WriteLine();
    }
}
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

void SearchNum(int[,] array)
{
    for (int number = 0; number < 10; number++)
    {
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if(array[i, j] == number)
                count++;
            }
        }
        if(count != 0)
        Console.WriteLine($"{number} встречается {count} раз");
    }
}

SearchNum(matrix);