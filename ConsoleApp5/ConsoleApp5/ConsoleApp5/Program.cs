using System;



namespace ConsoleApp5
{
    //https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/statements
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Let's understand all statements");

            Program.Declarations(10);

            Program.ConstantDeclarations();

            Program.Expressions();

            Program.IfStatement(50);

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda", "Lexus", "Lambo", "Seat","Toyota", "Opel" };

            Program.SwitchStatement(cars);
            Program.WhileStatement(cars);

            Program.DoStatement();

            Program.ForEachStatement(cars);

            Program.BreakStatement(cars);

            Program.ContinueStatement(cars);

            Console.WriteLine("Add: " + Program.Add(5, 6));

            Program.ReturnStatement(cars);

        }


        //Local variable declaration
        private static void Declarations(int d)
        {
            int a;
            int b = 2, c = 3;
            a = 1;
            Console.WriteLine("Local variable declaration:");
            Console.WriteLine("We are (not) adding (just concatenate) a + b + c + d: "+ a + b + c + d);


        }
        
        //Local constant declaration
        private static void ConstantDeclarations()
        {
            const float pi = 3.1415927f;
            const int r = 25;
            Console.WriteLine("Local constant declaration:");
            Console.WriteLine("Pi * radius: " + pi * r * r);
        }
        
        //Expression statement
        static void Expressions()
        {
            int i;
            i = 123;                // Expression statement
            Console.WriteLine("Expression statement: "); // Expression statement
            Console.WriteLine(i);   // Expression statement
            i++;                    // Expression statement
            Console.WriteLine(i);   // Expression statement
        }

        //if statement
        static void IfStatement(int value)
        {
            if ( value == 0)
            {
                Console.WriteLine("No number");
            }
            else
            {
                Console.WriteLine("There is a number");
            }
        }
        
        //switch statement
        static void SwitchStatement(string[] args)
        {
            int n = args.Length;
            switch (n)
            {
                case 0:
                    Console.WriteLine("No arguments");
                    break;
                case 1:
                    Console.WriteLine("One argument");
                    break;
                case 6:
                    Console.WriteLine("Lambo y Lexus molan");
                    break;

                default:
                    Console.WriteLine($"{n} arguments");
                    break;
            }
        }
        
        //while statement
        static void WhileStatement(string[] args)
        {
            int i = 0;
            while (i < args.Length)
            {
                Console.WriteLine(args[i]);
                i++;
            }
        }
        
        //do statement
        static void DoStatement()
        {
            string str;
            do
            {
                str = Console.ReadLine();
                Console.WriteLine(str);
            } while (!string.IsNullOrEmpty(str));
        }

        //for statement
        static void ForEachStatement(string[] args)
        {
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }
        }

        //break statement
        static void BreakStatement(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();
                if (string.IsNullOrEmpty(s))
                    break;
                Console.WriteLine(s);
            }
        }

        //continue statement
        static void ContinueStatement(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith("/"))
                    continue;
                Console.WriteLine(args[i]);
            }
        }

        //return statement simple
        static int Add(int a, int b)
        {
            return a + b;
        }

        //return statement with statement
        static void ReturnStatement(string[] args)
        {
            Console.WriteLine(Add(1, 2));


            return;
        }

    }
}
