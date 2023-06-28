namespace Pattern
{
    class Program
    {
        static void Main(string[] args) {
            string name = "Mark";
            string hello = $"Hello my name is {name}";
            Console.WriteLine(hello);

            int num1 = 10;
            double num2 = 0.1;

            //top is right alligned and bottom is left
            Console.WriteLine($"test {num1,5}!");
            Console.WriteLine($"test {num1,-5}!");

            //can also format C0 is currency and N is number P is procent
             Console.WriteLine($"test {num1:C0}!");
             Console.WriteLine($"test {num1:N}!");
             Console.WriteLine($"test {num2:P}!");

             //Can also use expressions
             Console.WriteLine($"{hello.ToUpper()} and today is {DateTime.Now.DayOfWeek}");

             //use @ if you want escaping to be ignored. Escapse can be \n for new line or  \\ for backslash
             Console.WriteLine(@"go to \\10.15.15.155\data");

             //Raw string for text block. start and end qoutes must be on their own line
             var stringBlock ="""
             THIS IS A STRING BLOCK
             IT CAN GO ON AND ON AND ON
             """;
             Console.WriteLine(stringBlock);

         }
    }
}
