namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value type
            //simple types like int, cha, bool, double, structs etc..
            //When passed to a method a copy is made so method only effects copy and not orginal
            int val = 100;
            //  Console.WriteLine("Before method call, value of val : " + val);
            changeVal(val);
            //  Console.WriteLine("After method call, value of val : " + val);

            //Ref type
            //classes, interface , array and delegates etc...
            //is passed by reference so any change that happens in method wil effect original
            Number t = new Number() { Value = 100 };
            //   Console.WriteLine("Before method call, value of t.Value : " + t.Value);
            ChangeReferenceType(t);
            //   Console.WriteLine("After method call, value of t.Value : " + t.Value);


            //We can pass value types as reference by using ref keyword
            //value mustbe initialized
            // states that we may modify it
            //   Console.WriteLine("Before method call, value of val : " + val);
            changeValRef(ref val);
            //   Console.WriteLine("After method call, value of val : " + val);

            //can use out keywork if not initialized
            //also states we must change value in method
            int val2;
            init(out val2);
            //   Console.WriteLine("After method call, value of val : " + val2);

            //we use in keyword if we want to make sure value cannot be modified

            // print(in val2);

            //we can use rither positonal or named parameters
            int num1 = 5;
            int num2 = 7;
            //  AddNumber(num1, num2);
            //  AddNumber(last: num2, first: num1);

            //Optinal parameters
            //can use overloading
            //  AddNumber(num1);

            //Method param
            // AddNumber(1, 2, 3, 4, 5, 6);

            //default val
            //   AddNumberDefault(3);
            //   AddNumberDefault(3,6);
            //AddNumberDefault();

         

        }

        public static void init(out int x)
        {
            x = 500;
        }

        static void print(in int x)
        {
            Console.WriteLine("Value of x : " + x);
            // will fail if we try and change x
            // x = 200;
        }

        public static void changeVal(int x)
        {
            x = 200;
        }

        public static void changeValRef(ref int x)
        {
            x = 200;
        }

        static void ChangeReferenceType(Number t)
        {
            t.Value = 200;
        }

        public static void AddNumber(int first, int last)
        {
            Console.WriteLine(first + last);
        }

        //overload
        public static void AddNumber(int first)
        {
            AddNumber(first, 0);
        }

        //method param
        public static void AddNumber(params int[] numbers)
        {
            int res = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                res += numbers[i];
            }
            Console.WriteLine(res);
        }

        //default. last must be default can have first being default with
        public static void AddNumberDefault(int first = 3, int last = 0)
        {
            AddNumber(first, last);
        }
        //DOES NOT WORK SINCE last parameter is not default
      /*  public static void AddNumberDefault(int first = 3, int last)
        {
            AddNumber(first, last);
        }*/
        class Number
        {
            public int Value { get; set; }
        }
    }
}
