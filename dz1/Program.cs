﻿// Задача 2: Напишите программу, которая на вход принимает 
//два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

internal class Program
{
    private static void Main(string[] args)
    {
        {
            Console.WriteLine("Введите 1 число ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 число ");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("{0}наибольшее число", a);
            }
            else
            {
                Console.WriteLine("{0}наибольшее число", b);
            }
        }
    }
}