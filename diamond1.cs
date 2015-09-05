using System;
    class Program
    {
        static int a = 5;
        static void Main(string[] args)
        {
            for (int i = 1; i <= a; i++)
            {
                for (int k = a; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = a ; i >= 1; i--)
            {
                for (int k = a; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {

                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
        
    }
