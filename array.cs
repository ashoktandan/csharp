using System;
    class Program
    {
        static int i, j;
        static void Main(string[] args)
        {                    
           Console.WriteLine("enter no of students");
           i = int.Parse(Console.ReadLine());
           Console.WriteLine("enter no of subjects");
           j = int.Parse(Console.ReadLine());
           int[,] arr = new int[i, j];
           for (int w = 0; w < i; w++)
           {
               Console.WriteLine("for " + (w+1) + " student");
               for (int x = 0; x < j; x++)
               {
                   Console.Write("enter " + (x+1) + " subject marks= ");
                   arr[w, x] = int.Parse(Console.ReadLine());                
               }
           }
               for (int u = 0; u < i; u++)
               { 
                   Console.WriteLine("student "+(u+1)+" marks are: ");
                   for (int y = 0; y < j; y++)
                   {
                       Console.WriteLine(arr[u, y]);
                   }
               }                       
           Console.ReadLine();
        }
    }
