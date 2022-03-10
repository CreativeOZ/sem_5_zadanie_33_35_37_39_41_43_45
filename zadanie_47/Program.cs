// Написать программу копирования массива
Console.Clear();

int[] array = new int[12];
for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 5);
        Console.Write(array[i] + " ");
    }
Console.WriteLine();
int[] array2 = new int[12];
for (int i = 0; i < array2.Length; i++)
    {
        array2[i] = array[i];
        Console.Write(array2[i] + " ");
    }
