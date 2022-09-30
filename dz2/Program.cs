 Console.WriteLine("Введите 3 числа ");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
    Console.WriteLine($"{a} наибольшее число");
    }
    else
    {
    Console.WriteLine($"{c} наибольшее число");
    }
    }else{
    if (c > b)
    {
    Console.WriteLine($"{c} наибольшее число");
    }
     else
    {
    Console.WriteLine($"{b} наибольшее число");
    }
    }
