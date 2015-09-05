using System;
class prog
{
    public static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 5; j > i; j--)
            {
                Console.Write(" ");   
            }
            for (int k = 0; k < i; k++)
            {
                Console.Write("*");
            }

            for (int k = 1; k < i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }

        for (int i = 5; i > 0; i--)
        {
            for (int j = 5; j > i; j--)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < i; k++)
            {
                Console.Write("*");
            }
            for (int k = 1; k < i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }


        Console.ReadLine();
    }
}
