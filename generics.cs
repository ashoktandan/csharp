using System;
class Pro<T>
    { 
    public Pro(T n)
            {
                Console.WriteLine(n);
            }
        }
class foo
{
    static void Main()
    {
        Pro<int> obj = new Pro<int>(55);
        Pro<string> obj1 = new Pro<string>("ashok");
        Console.ReadLine();
    }
}
