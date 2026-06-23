/*var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();*/
using System;

namespace Program
{
    class Math
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey");
            Console.WriteLine("Welcome to my math program");

            Boolean active1 = true;
        }

        static void mathMenu(Boolean status)
        {
            Console.WriteLine("Loading in...");

            while(status)
            {
                Console.WriteLine("===Choose an option===");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");
                Console.WriteLine("5 - Which is higher");
                Console.WriteLine("6 - Is a primary number");
                Console.WriteLine("7 - Are they equal");
                Console.WriteLine("8 - Percentage");
                Console.WriteLine("0.");

                String sa;
                int ia;
                String sb;
                int ib;
                int r;

                string sc = Console.ReadLine();
                int c = Int32.Parse(sc);

                switch(c)   {
                    case 1: Console.WriteLine("You chose Addition");

                        Console.WriteLine("Write the first number:");
                        sa = Console.ReadLine();
                        ia = Int32.Parse(sa);
                        Console.WriteLine("Write the second number:");
                        sb = Console.ReadLine();
                        ib = Int32.Parse(sb);

                        r = Addition(ia,ib);
                        Console.WriteLine(sa," plus ",sb," equals ",r);
                        break;

                    case 2: Console.WriteLine("You chose Subtraction");

                        Console.WriteLine("Write the first number:");
                        sa = Console.ReadLine();
                        ia = Int32.Parse(sa);
                        Console.WriteLine("Write the second number:");
                        sb = Console.ReadLine();
                        ib = Int32.Parse(sb);

                        r = Subctraction(ia,ib);
                        Console.WriteLine(sa," minus ",sb," equals ",r);
                        break;
                    
                    case 3: Console.WriteLine("You chose Multiplication");

                        Console.WriteLine("Write the first number:");
                        sa = Console.ReadLine();
                        ia = Int32.Parse(sa);
                        Console.WriteLine("Write the second number:");
                        sb = Console.ReadLine();
                        ib = Int32.Parse(sb);

                        r = Multiplication(ia,ib);
                        Console.WriteLine(sa," times ",sb," equals ",r);
                        break;

                    case 4: Console.WriteLine("You chose Division");

                        Console.WriteLine("Write the first number:");
                        sa = Console.ReadLine();
                        ia = Int32.Parse(sa);
                        Console.WriteLine("Write the second number:");
                        sb = Console.ReadLine();
                        ib = Int32.Parse(sb);

                        r = Division(ia,ib);
                        Console.WriteLine(sa," times ",sb," equals ",r);
                        break;

                        default:
                        break; 
                }
            }
        }

        static int Addition(int a, int b)
        {
            return a+b;
        }
        static int Subctraction(int a, int b)
        {
            return a-b;
        }
        static int Multiplication(int a, int b)
        {
            return a*b;
        }
        static int Division(int a, int b)
        {
            return a/b;
        }
    }
}
