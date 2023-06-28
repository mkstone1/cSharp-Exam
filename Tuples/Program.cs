namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // can contain up to 8 parts
            Tuple<string, string> t1 = new Tuple<string, string>("hello", "world");
            // Console.WriteLine($"t1 contains item1 = {t1.Item1} and item2 = {t1.Item2}");

            Tuple<string, int> t2 = new Tuple<string, int>("contain string and numbers", 2);
            //Console.WriteLine($"t2 contains item1 = {t2.Item1} and item2 = {t2.Item2}");

            var t3 = Tuple.Create("hello", true);
            //Console.WriteLine($"t3 contains item1 = {t3.Item1} and item2 = {t3.Item2}");


            //deconstruction
            (string a, string b) = t1;
            // Console.WriteLine($"Tuple is now deconstructed to a={a} and b= {b}");

            var t4 = (a, b, 5);
            Console.WriteLine(
                $"t3 contains item1 = {t4.Item1} and item2 = {t4.Item2} and item3 = {t4.Item3}"
            );

            var t5 = ReturnAsTuple(3, 5);

            var t6 = TupleWithNamedProperties(3, 4);

            Console.WriteLine($"t6 contains item1 = {t6.num1} and item2 = {t6.num2}");

            Rectangle r1 = new Rectangle(1, 3);
            var (side1, side2) = r1;
            Console.WriteLine($"object deconstruction = {side1} and item2 = {side2}");
        }

        public static (int, int) ReturnAsTuple(int num1, int num2)
        {
            return (num1, num2);
        }

        public static (int num1, int num2) TupleWithNamedProperties(int a, int b)
        {
            return (num2: b, num1: a);
        }
    }

    public class Rectangle
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }

        public void Deconstruct(out int side1, out int side2)
        {
            side1 = Side1;
            side2 = Side2;
        }

        public Rectangle(int side1, int side2){
            Side1 = side1;
            Side2 = side2;
        }
    }
}
