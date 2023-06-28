namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Town kbh = new Town("kbh");
            kbh.size = 10;
            kbh.country = "dk";
            kbh.setPopulation(2);
            Console.WriteLine(kbh.Density);

            //using object initalisers
            Town aab = new Town("aab") { size = 8, country = "dk" };
            aab.setPopulation(1);
            Console.WriteLine(aab.Density);

            var anonTown = new Town("anon") { size = 100, country = "us" };

            Person p1 = new("mark", "stone");

            Console.WriteLine(p1);

            Person p2 = p1 with { firstName = "oliver" };
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }

    //can be changed to struct by replacing class with struct.
    // struct is value type not refrence type
    // no inheritance in struct
    // can create new instances by copy
    //you can also have abstract classes with abstract methods.
    //Abstract classes cannot be instasiated and abstract methods must be implemented by children
    public class Town
    {
        //fields
        private string name;

        //properties with auto implemented properties {get; set;}
        public int size { get; set; }

        public string country { get; set; }

        private int population { get; set; }

        public void setPopulation(int num)
        {
            population = num;
        }

        //property
        public float Density
        {
            get => size / population;
        }
        

        //uses constructor chaining to call other constructor with default value
       
       // public Town (): this("Unknow name");

        public Town(string name)
        {
            this.name = name;
        }
    }

    public class MegaCity: Town {

        public string famousFor{get; set;}

        public void isFamousFor(){
            Console.WriteLine(this.famousFor);
    }
    //contructor chaining with base
    public MegaCity(string name, string famousFor): base(name){
        this.famousFor = famousFor;
    }
    }

    record Person(string firstName, string lastName);
}
