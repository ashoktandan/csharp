using System;
delegate void del(int n);
class pro
{
    static void show(int a)
    {
        Console.Write(a);
    }
    static void Main()
    {
        del o = new del(show);
        o(55);
        Console.ReadLine();
    }
}
