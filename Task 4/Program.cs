/* Задача 8: Напишите программу, которая на вход принимает
число (N), а на выходе показывает все чётные числа от 1 до N.
*/


Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int i = 2;
Console.WriteLine("Последовательность четных чисел:");
while (i <= n)
{
Console.Write(i);
if (i != n && i != n-1)
    {
    Console.Write(',');
    }
i = i + 2;
}
