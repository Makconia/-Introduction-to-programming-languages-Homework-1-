// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.


Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2 && number1 > number3)
    {
        Console.WriteLine("Наибольшее число: ");
        Console.WriteLine(number1);
    }
else if (number2 > number3)
    {
        Console.WriteLine("Наибольшее число: ");
        Console.WriteLine(number2);
    }
else
        {
        Console.WriteLine("Наибольшее число: ");
        Console.WriteLine(number3);
        }
