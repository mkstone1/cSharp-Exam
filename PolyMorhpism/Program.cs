namespace Pattern
{
    class Program
    {
        static void Main(string[] args) {
            Animal b1 = new Animal("bird1");
            Bird b2 = new Bird("bird2", true);
            Animal b3 = new Bird("bird3", true);

            //Static dispatch as bird3 jumps
            b1.jump();
            b2.jump();
            b3.jump();

            //Dynmaic dispaych cause of virtual method
            b1.fly();
            b2.fly();
            b3.fly();


         }
    }

    public class Animal{
        public string name {get;set;}

        public Animal(string name){
            this.name = name;
        }

        public void jump(){
            Console.WriteLine(name + " jumps");
        }

        public virtual void fly(){
            Console.WriteLine("cant fly sorry");
        }
    }

    public class Bird:Animal{
        

        //Wont be inherited becasuse sealed. Classes can also be sealed
       // public sealed bool canfly;

        public Bird(string name, bool canfly) : base(name){
         //   this.canfly = canfly;
        }

        public void jump(){
            Console.WriteLine("can birds jump?");
        }

        public override void fly()
        {
            Console.WriteLine("WE ARE FLYING");
        }


    }
}
