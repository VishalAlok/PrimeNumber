using System;
public class PrimeNumberExample
{
    public static void Main(string[] args)
    {
        int number, half = 0, flag = 0;

        Console.Write("Enter the Number to check Prime: ");
        number = int.Parse(Console.ReadLine());

        half = number / 2;

        for (int i = 2; i <= half; i++)
        {
            if (number % i == 0)
            {
                Console.Write("Number is not Prime. ");
                flag = 1;
                break;
            }
        }
        if (flag == 0)
            Console.Write("Number is Prime. ");
    }
}