using System;
using System.ComponentModel;

class Program
{
    public static void Main(string[] args)
    {

        //Dia.triangle();
        //Dia.triang();
        //Dia.squer();
        Dia.tall();
    }
}

class Dia
{
    public static void triangle()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10 - i; j++)
                Console.Write(" ");
            for (int j = 1; j <= i * 2 - 1; j++)
            {
                Console.Write("*");

            }
            Console.WriteLine();
        }
    }

   

    public static void squer()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public static void triang()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= i; j++)

                Console.Write("*");

            Console.WriteLine();
        }
    }
    public static void tall()
    {
        string[] words = { "mohammed", "khaled", "subhi" };
        string longestWord = ""; 
        int longer = 0; 
        for (int i = 0; i < words.Length; i++) 
        {
            if (words[i].Length > longer) 
            {
                longer = words[i].Length; 
                longestWord = words[i]; 
            }
        }

        Console.WriteLine("The length of the longest word = " + longer);
        Console.WriteLine("The longest word = " + longestWord);
    }
}
