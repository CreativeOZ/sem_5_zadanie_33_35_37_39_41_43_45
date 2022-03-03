// 35. Определить, присутствует ли в заданном массиве, некоторое число
Console.Clear();

int [] array = new int [12];
void FillArray(int [] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(-50, 51);
    }
}
FillArray(array);

void PrintArray(int [] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]}   ");
    }
}
PrintArray(array);

Console.WriteLine();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int b = Array.IndexOf(array, a);
{
    if (b == -1) Console.WriteLine("Данное число отсутствует в массиве");
    else Console.WriteLine($"Данное число есть в массиве с позицие {b+1}");
}
