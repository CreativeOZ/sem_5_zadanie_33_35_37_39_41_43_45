// 43. Написать программу преобразования десятичного числа в двоичное
Console.Clear();
/* Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine()); */
/* string b = Convert.ToString(a, 2);
/* Console.WriteLine(b); */ // Вариант № 1.

/* int b = 0; */
/* while (a != 0)
{
    b = a % 2;
    a = a / 2;
    Console.Write($"{b}");
} */ // Вариант № 2.

int number=new Random().Next(0,100);
Console.Write(number);
Console.WriteLine();
string result = " ";
while (number!=0) {
result=(number%2).ToString()+result;
number=number/2;
}

Console.WriteLine(result);
