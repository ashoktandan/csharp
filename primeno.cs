using System;
class Program
{
    static void Main(string[] args)
    {
        bool prime=true;
        for (int i = 3; i <= 100; i++)
        {
            for (int j = 2; j <= 99; j++)
            {
                if (i != j && i % j == 0)
                {
                    prime = false;
                }
            }
            if (prime)
            {
                Console.WriteLine(i);
            }
            prime = true;
        }
        Console.ReadLine();
    }
}
