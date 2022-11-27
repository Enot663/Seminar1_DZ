// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Clear();

int i = 1;
bool not = true;

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Чётные числа от 1 до {num}");
while (i <= num)
{
    if (i % 2 == 0)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
}

if (not)
{
    Console.WriteLine("Нет чётных чисел!");
}
