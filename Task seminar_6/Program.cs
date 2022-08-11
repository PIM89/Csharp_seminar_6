/* Напишите программу, на вход которой подаётся прямоугольная матрица в виде последовательности строк. 
После последней строки матрицы идёт строка, содержащая только строку "end" (без кавычек, см. Sample Input).
Программа должна вывести матрицу того же размера, у которой каждый элемент в позиции i, j равен сумме элементов 
первой матрицы на позициях (i-1, j), (i+1, j), (i, j-1), (i, j+1). У крайних символов соседний элемент находится с 
противоположной стороны матрицы.
В случае одной строки/столбца элемент сам себе является соседом по соответствующему направлению.
Sample Input 1:
9 5 3
0 7 -1
-5 2 9
end
Sample Output 1:
3 21 22
10 6 19
20 16 -1
Sample Input 2:
1
end
Sample Output 2:
4*/

Console.Write("Введите количество строк(столбцов) прямоугольной матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int colums = rows;
int[,] matrix = new int[rows, colums];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("End");
Console.WriteLine();

int[,] new_matrix = new int[rows, colums];
for (int i = 0; i < new_matrix.GetLength(0); i++)
{
    for (int j = 0; j < new_matrix.GetLength(1); j++)
    {
        if (i == 0 && j == 0) new_matrix[i, j] = matrix[new_matrix.GetLength(0) - 1, j] + matrix[i+1, j] + matrix[i, new_matrix.GetLength(0) - 1] + matrix[i, j+1];
        if (i == 0 && j > 0 && j < new_matrix.GetLength(0)-1) new_matrix[i, j] = matrix[new_matrix.GetLength(0) - 1, j] + matrix[i, j+1] + matrix[i+1, j] + matrix[i, j - 1];
        if (i == 0 && j == new_matrix.GetLength(0)-1) new_matrix[i, j] = matrix[new_matrix.GetLength(0)-1, j] + matrix[i, 0] + matrix[i + 1, new_matrix.GetLength(0)-1] + matrix[i, j-1];
        if (i > 0 && i < new_matrix.GetLength(0)-1 && j == 0) new_matrix[i, j] = matrix[i-1, j] + matrix[i, j+1] + matrix[i+1, j] + matrix[i, new_matrix.GetLength(0)-1];
        if (i == new_matrix.GetLength(0)-1 && j == 0) new_matrix[i, j] = matrix[i-1, j] + matrix[i, j+1] + matrix[0, 0] + matrix[i, new_matrix.GetLength(0)-1];
        if (i == new_matrix.GetLength(0)-1 && j > 0 && j < new_matrix.GetLength(0)-1) new_matrix[i, j] = matrix[i-1, j] + matrix[i, j+1] + matrix[0, j] + matrix[i, j-1];
        if (i == new_matrix.GetLength(0)-1 && j == new_matrix.GetLength(0)-1) new_matrix[i, j] = matrix[i-1, j] + matrix[i, 0] + matrix[0, new_matrix.GetLength(0)-1] + matrix[i, j - 1];
        if (i > 0 && i < new_matrix.GetLength(0)-1 && j > 0 && j < new_matrix.GetLength(0)-1) new_matrix[i, j] = matrix[i - 1, j] + matrix[i, j + 1] + matrix[i+1, j] + matrix[i, j - 1];
        if (i > 0 && i < new_matrix.GetLength(0)-1 && j == new_matrix.GetLength(0)-1) new_matrix[i, j] = matrix[i-1, j] + matrix[i, 0] + matrix[i + 1, j] + matrix[i, j-1];
        Console.Write($"{new_matrix[i, j]} ");
        
    }
    Console.WriteLine();
}