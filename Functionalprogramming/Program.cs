using System;
using System.Text;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new[] { new Person("Hans"), new Person("Mark"), new Person("Oskar") };

            //Imparetive or old way

            foreach (var person in people)
            {
                //Console.WriteLine(person.Name);
            }

            //Functional way
            //people.Select(person => person.Name).ToList().ForEach(name => Console.WriteLine(name));



            //immutable data

            Person p1 = new Person("Mark");
            p1.Height = 189;

            //changes p1 and therefore not immutable
            p1.Grow();
            Console.WriteLine(p1.Height);

            //New on mutation can be record to make it immutable
            p1 = p1.GrowImut();

            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Height);

            //Non functional way of doing it
            // No reason to create a function with variables and mutate it
            string greeting = Greeting(true);

            //Functional way
            var Greet = (bool isMale) => isMale ? "Hello there sir" : "Hello there miss";
            Console.WriteLine(Greet(false));

            // can call function with result from another function
            //Will be function primitive if it return result
            // will be action primitive if it does not
            var addOne = (int num) => num + 1;
            var printInt = (int num) => Console.WriteLine(num);
            printInt(addOne(2));

            //Builder patterns and method chaining
            string str = new StringBuilder().Append("Hello ").Append("World").ToString().ToUpper();
            //can also use extension methods
            string otherStr = new StringBuilder().Append("<button ").AppendWhen("onclick={function}>", true).ToString();
            Console.WriteLine(otherStr);

            Console.WriteLine(getTicketPrice(11,DateTime.Now));

        
        }

        public static int getTicketPrice(int groupSize, DateTime date)
         => (groupSize, date.DayOfWeek) switch{
            (<=0, _ ) => throw new Exception("size must be bigger than 0"),
            (_ , DayOfWeek.Saturday or DayOfWeek.Sunday) => 10,
            ( >= 5 and <=10, _) => 15,
            ( > 10, DayOfWeek.Tuesday) => 20 
         };

        public static string Greeting(bool isMale)
        {
            string Greeting;
            if (isMale)
            {
                Greeting = "Hello there sir";
            }
            else
            {
                Greeting = "Hello there miss";
            }
            return Greeting;
        }
    }

    public static class StringBuilderExtensions
    {
        public static StringBuilder AppendWhen(
            this StringBuilder sb,
            string value,
            bool toAppend
        ) => toAppend ? sb.Append(value) : sb;
    }

    public class Person
    {
        public string Name { get; set; }
        public int Height { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public void Grow()
        {
            Height++;
        }

        public Person GrowImut()
        {
            Person p = new Person(this.Name);
            p.Height = this.Height + 1;
            return p;
        }
    }
}
