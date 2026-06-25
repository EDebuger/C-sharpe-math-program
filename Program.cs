/*var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();*/
using System;

namespace Program
{
    class MathProgram
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
                        Console.WriteLine(sa," divided by ",sb," equals ",r);
                        break;

                    case 5: Console.WriteLine("You chose Comparing to get higher number");

                        Console.WriteLine("Write the first number:");
                        sa = Console.ReadLine();
                        ia = Int32.Parse(sa);
                        Console.WriteLine("Write the second number:");
                        sb = Console.ReadLine();
                        ib = Convert.ToInt32(sb);

                        r = higherNum(ia,ib);
                        Console.WriteLine(Convert.ToString(r), " is the higher number");
                        break;

                    case 6: Console.WriteLine("You chose Primary number check");

                        Console.WriteLine("Write the number:");
                        sa = Console.ReadLine();
                        ia = Int32.Parse(sa);

                        Boolean p = primaryCheck(ia);
                        if(p) Console.WriteLine(sa, " is a prime number");
                        else Console.WriteLine(sa, " is not a prime number");
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
        static int higherNum(int a, int b)
        {
            return Math.Max(a,b); // returns the higher
        }
        static Boolean primaryCheck(int a)
        {
        if (a <= 1){return false;}
      
        for (int i = 2; i* i <=a; i++) {
            if (a % i == 0)  
                return false;
                }
        return true;
        }
    }
}
