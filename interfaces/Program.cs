namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human("Mark", 29);
            h1.Talk();

            IHumanoid h2 = new Human("Nina", 30);
            h2.Talk();

            GotChar character = new GotChar("Jon Snow", 25, "Stark");
            ((IHumanoid)character).Talk();
            ((IWesterosi)character).Talk(); 
     
        }
    }

    public interface IHumanoid
    {
        string Name { get; set; }
        int Age { get; set; }
        void Talk();
    }

    public interface IWesterosi{
        string House {get;set;}

        void Talk(){
        }
    }

    public class Human : IHumanoid
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Talk()
        {
            Console.WriteLine("Hello, my name is " + Name + " and I am " + Age + " years old.");
        }
    }

    public class GotChar : IHumanoid, IWesterosi{
        public string Name {get;set;}
        public int Age {get;set;}
        public string House {get;set;}

        void IHumanoid.Talk(){
            Console.WriteLine("I am human");
        }
        void IWesterosi.Talk(){
            Console.WriteLine("I am from house " + House);
        }

        public GotChar(string Name, int Age, string House){
            this.Name = Name;
            this.Age = Age;
            this.House = House;


        }
    }
}
