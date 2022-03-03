// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. 
//Найти сумму положительных/отрицательных элементов массива

Console.Clear();

int[] array = new int[12];
void FillArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(-50, 51);
    }
}
FillArray(array);

void PrintArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]}  ");
    }
}
PrintArray(array);
int positive = 0;
int negative = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array [i] > 0) positive +=array[i];
    else negative +=array[i];
}
Console.WriteLine();
Console.Write($"В заданном массиве сумма положительных чисел = {positive}, отрицатеных чисел = {negative}.");
