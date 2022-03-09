using System;

enum month
{
    January = 0,
    February = 1,
    March = 2,
    April = 3,
    May = 4,
    June = 5,
    July = 6,
    August = 7,
    September = 8,
    October = 9,
    November = 10,
    December = 11
}

public class Problem
{
    public static void Main()
    {

        int userInput = int.Parse(Console.ReadLine());
        string monthOutput = Enum.GetName(typeof(month), userInput - 1);

        do
        {
            Console.WriteLine("Digite um número válido de 1 a 12!");
            userInput = int.Parse(Console.ReadLine());
            monthOutput = Enum.GetName(typeof(month), userInput - 1);
        }
        while (userInput > 11 | userInput < 0);
        {
            Console.WriteLine(monthOutput);
        }
        Console.ReadLine();
    }
}