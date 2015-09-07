using System;
class Program
    {
    static int x=0,y=1,z = 0;
        static void Main(string[] args)
        {
             Console.WriteLine(x);
             Console.WriteLine(y);
            for (int i = 0; i < 10; i++)
            {
                z = x+y;
                    Console.WriteLine(z);
                    x = y;
                    y = z;
            }
            Console.ReadLine();
        }
    }
