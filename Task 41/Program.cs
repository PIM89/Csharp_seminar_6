/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4*/

Console.Write("Введите цифры через ',': ");
string text = Console.ReadLine();
string[] array = text.Split(',');
int[] mas = new int[array.Length];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    mas[i] = Convert.ToInt32(array[i]);
    if (mas[i] > 0) count++;
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}
PrintArray(mas);
Console.WriteLine();
Console.WriteLine($"{count} чисел(а) больше 0");
