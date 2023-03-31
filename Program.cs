// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
//
// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//
// 4 -> дай
// -3 -> нет
// 7 -> нет
//
// Задача 4: Напишите программу, которая на вход принимает число (N), а нfа выходе показывает все чётные числа от 1 до N.
//
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число А->");
        string valueA; // Объявление переменной типа строка
        valueA = Console.ReadLine(); // Считываем с консоли строку
        int numberA = Convert.ToInt32(valueA); // переводим введеное значение в числовой режим

        Console.WriteLine("Введите число B->");
        string valueB; // Объявление переменной типа строка
        valueB = Console.ReadLine(); // Считываем с консоли строку
        int numberB = Convert.ToInt32(valueB); // переводим в числовой формат

        Console.WriteLine("Введите число C->");
        string valueC; // Объявление переменной типа строка
        valueC = Console.ReadLine(); // Считываем с консоли строку
        int numberC = Convert.ToInt32(valueC); // переводим введеное значение в числовой режим

        int numberMax1;
        int numberMax2;
        int numberMAX;
        if (numberA > numberB)
        {
        numberMax1 = numberA;
        }
        else
        {
        numberMax1 = numberB;
        }
        if (numberB > numberC)
        {
        numberMax2 = numberB;
        }
        else
        {
        numberMax2 = numberC;
        }
        if (numberMax1 > numberMax2)
        {
        numberMAX = numberMax1;
        }
        else
        {
        numberMAX = numberMax2;
        }
        Console.WriteLine("Максимальное число - " + numberMAX);
    }
}