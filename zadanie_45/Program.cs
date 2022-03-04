// 45. Показать числа Фибоначчи
Console.Clear();
Console.Write("Покажи числа Фибоначчи: ");
int count = int.Parse(Console.ReadLine());
int a = 1;
int b = 1;
int fibo = 0;
Console.Write($"{a}\t{b}\t");
for (int i = 0; i < count-2; i++)
{
    fibo = a+b;
    a=b;
    b=fibo;
    Console.Write($"{fibo}\t");
}
Console.WriteLine();