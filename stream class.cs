using System;
using System.IO;
class Program
    {
        static void Main(string[] args)
        {
            string id, name, email, output, choice;
            Console.WriteLine("enter 1.add   2.fetch");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("enter id,name,email");
                id = Console.ReadLine();
                name=Console.ReadLine();
                email = Console.ReadLine();
                StreamWriter sw = new StreamWriter(id + ".txt");
                sw.WriteLine(id);
                sw.WriteLine(name);
                sw.WriteLine(email);
                sw.Close();
                Console.WriteLine("user added");
            }
            else if (choice == "2")
            {
                Console.WriteLine("enter id");
                id = Console.ReadLine();
                StreamReader sr = new StreamReader(id + ".txt");
                Console.WriteLine("user id,name & email are");
                while ((output = sr.ReadLine()) != null)
                {
                    Console.WriteLine(output);
                }
            }
            else {
                Console.WriteLine("wrong input");
            }
            Console.ReadLine();
        }
    }

