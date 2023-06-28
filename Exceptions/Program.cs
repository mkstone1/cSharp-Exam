namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // error();

            try
            {
                error();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("error was caught");
            }

            try
            {
                error();
            }
            catch (Exception e)
            {
                Console.WriteLine("error was also caught");
            }
            finally
            {
                Console.WriteLine("Final");
            }

            //checks if length >1 if this is true it will return 12 else it will throw exception
            //can do this since throw is a statement and expression
            int length = 3; 
            int result = length > 1 ? 12 : throw new ArgumentException("No..");

            Console.WriteLine(result);

            string test = null;
            //string test ="test";

            string input = test ?? throw new ArgumentNullException("Fail");

            Console.WriteLine(input);
        }

        static void error()
        {
            File.ReadAllText("test");
        }
    }
}
