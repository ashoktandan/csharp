using System;
public class hello
{
    public void method1(string name)
    {
        name = "method1";
    }
    public void method2(ref string name)
    {
        name = "method2";
    }
    public void method3(out string name)
    {
        name = "method3";
    }
    static void Main()
    {
        hello h = new hello();
       string name = "Ashok";
       string name2;
       Console.WriteLine("pure value: " + name);
       h.method1(name);
       Console.WriteLine("value type: " + name);
       h.method2(ref name);//we write name variable here because it has value assigned
       Console.WriteLine("ref type: " + name);
       h.method3(out name2);//we write name2 here because it doesnot has value assigned although we can use both name and name2
       Console.WriteLine("out type: " + name2);
       Console.ReadLine();
    }
}
