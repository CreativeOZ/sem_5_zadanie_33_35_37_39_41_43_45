// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
 Console.Clear();

int [] array = new int [123];
void FillArray(int [] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(-100, 100);
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
int count = 1;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10 && array[1] <=99) count++;
}
Console.WriteLine($"\n Колличество чисел от [10, 99] - {count}");