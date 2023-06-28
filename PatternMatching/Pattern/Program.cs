namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write a number");
            string xString = Console.ReadLine();

            int x;

            if (int.TryParse(xString, out x))
            {
                x = int.Parse(xString);
            }
            else
            {
                Console.WriteLine("Input is not a number. Setting number to 0");
                x = 0;
            }

            if (x <= 3)
            {
                Console.WriteLine("3 or Below");
            }
            else if (x == 4)
            {
                Console.WriteLine("is 4");
            }
            else
            {
                Console.WriteLine("Above 4");
            }

            switch (x)
            {
                case < 2:
                case > 3
                and < 6:
                    Console.WriteLine("Between 3 and 6");
                    break;
                default:
                    break;
            }

            Console.WriteLine("write a string");

            string input = Console.ReadLine();

            if (x == 4 && input == "test")
            {
                Console.WriteLine("HURRAY");
            }

            switch (input)
            {
                case "hello":
                    Console.WriteLine("Hello World");
                    break;
                case "c#":
                    Console.WriteLine("C# is awesome");
                    break;
                default:
                    break;
            }

            string expression = input switch
            {
                "test" => "This is a test",
                "c#" => "C# is still awesome",
                _ => input
            };

            Console.WriteLine("expression is now " + expression);

            //decleration and type pattern
            if (input is string and string message)
            {
                //Console.WriteLine("Message using is " + message);
            }

            //Property pattern
            DateTime date = DateTime.Now;
            if (date is { Year: 2023, Month: 6 })
            {
                Console.WriteLine("it is june");
            }

            //Positional and discard pattern
            switch (x, input)
            {
                case (_, "test"):
                    Console.WriteLine("test");
                    break;

                case (4, _):
                    Console.WriteLine("x is 4");
                    break;

                case (> 4, _):
                    Console.WriteLine("bigger than 4");
                    break;

                case (3, "nottest"):
                    Console.WriteLine("is 3 and nottest");
                    break;
            }

            Console.WriteLine("write a number");
            string yString = Console.ReadLine();

            int y;

            if (int.TryParse(yString, out y))
            {
                y = int.Parse(yString);
            }
            else
            {
                Console.WriteLine("Input is not a number. Setting number to 0");
                y = 0;
            }


            //case guard
            switch (x, y)
            {
                case (> 0, > 0) when x == y:
                    Console.WriteLine("x and y and bigger than 0 and the same");
                    break;

                case (> 0, > 0):
                    Console.WriteLine("both are above 0 but not the same");
                    break;
            }
        }
    }
}
