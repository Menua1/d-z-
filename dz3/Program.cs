// Напишите программу, которая на вход принимает число и выдаёт, является ли 
//число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

internal class Program
{
    private static int i;

    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        
        i = int.Parse(Console.ReadLine());

        if (i % 2 == 0)
        {
            Console.Write("введеное число является четным ");
            Console.Read();
        }
        else
        {
            Console.Write("Введеное число является нечетным ");
            Console.Read();
        }
    }
}