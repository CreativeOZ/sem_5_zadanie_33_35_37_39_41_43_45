// 43. Написать программу преобразования десятичного числа в двоичное
Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
string b = Convert.ToString(a, 2);
Console.WriteLine(b);
