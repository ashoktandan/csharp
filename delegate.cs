using System;
delegate void mydel(int z);
class P
{
     static void show(int b)
    {
        Console.Write(b);
    }
    static void Main()
    {
        mydel obj;
        obj= new mydel(show);
        obj(9);
        Console.ReadLine();
    }
}
