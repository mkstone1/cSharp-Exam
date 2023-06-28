namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Null value object
            Human h1 = null;

            //null coalescing - checks if h1 is null or else runs code after ??
            Human h2 = h1 ?? new Human("Mark");

            h2.getName();

            //null-propergation. h1.name is null but with the ? it does not throw and error
            var name = h1?.Name;
            //will throw exception
            var name2 = h1.Name;

            Console.WriteLine(name);
        }
    }

    public class Human
    {
        public string Name { get; set; }

        public Human(string Name)
        {
            this.Name = Name;
        }

        public void getName(){
            Console.WriteLine(this.Name);
        }
    }
}
