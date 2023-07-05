using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите необходимый баланс");
        int balans = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите необходимый вес");
        int weight =Convert.ToInt32( Console.ReadLine());
        Console.WriteLine("Введите необходимую стоимость");
        int cost = Convert.ToInt32( Console.ReadLine());
        int sum = weight * cost;
        balans+= sum;
        Console.Write("Итоговый баланс равен:_");
        Console.WriteLine(balans);
    }
}