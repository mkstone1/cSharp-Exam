namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 30;
            //int has a method we can call therefore an object
            string xString = x.ToString();

            if (x.GetType() == typeof(int))
            {
                Console.WriteLine("its an int");
            }

            if (x is int)
            {
                Console.WriteLine("Also int");
            }

            Animal a = new Dog();
            Dog d = a as Dog;

            a.Name = "Animal";
            //you should not use operators to modify an object but use them to generate a new one;
            Animal modifyied = ~a;
            Console.WriteLine(modifyied.Name);
        }

        class Animal
        {
            public string Name { get; set; }

            public static Animal operator ~(Animal a)
            {
                var animal = new Animal();
                animal.Name = "~" + a.Name;
                return animal;
            }
        }

        class Dog : Animal { }
    }
}
