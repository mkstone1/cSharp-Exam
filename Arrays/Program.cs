namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3] { 2, 1, 3 };
            int[] numbers2 = { 1, 2, 3 };
            var numbers3 = new[] { 1, 2, 3 };
            string[] strings = new string[3] { "Hello ", "general ", "Kenobi" };

            for (int i = 0; i < numbers.Length; i++)
            {
            //    Console.WriteLine(numbers[i]);
            }

            foreach (var word in strings)
            {
            //    Console.Write(word);
            }
            /*
            Console.WriteLine("max is " + numbers.Max());
            Console.WriteLine("min is " + numbers.Min());
            Console.WriteLine("sum is " + numbers.Sum());
            Console.WriteLine("Average is " + numbers.Average());
            */

            foreach (int num in numbers)
            {
              //  Console.WriteLine($"unsorted number is {num}");
            }
            Array.Sort(numbers);
            foreach (int num in numbers)
            {
           //     Console.WriteLine($"sorted number is {num}");
            }

            Array.Reverse(numbers);

              foreach (int num in numbers)
            {
             //   Console.WriteLine($"Reverse sorted number is {num}");
            }

            int[] copy = new int[3];

            Array.Copy(numbers, copy, 3);
             foreach (int num in copy)
            {
               // Console.WriteLine($"copied number is {num}");
            }

            add10(copy);
              foreach (int num in copy)
            {
               // Console.WriteLine($"with 10 added {num}");
            }


            int [][] jaggedArray = {
                copy,
                numbers2,
                numbers,
                new int[] {1,2,3,4,5}
            };

            for(int i =0; i < 4; i++){
               // Console.WriteLine("First column " + jaggedArray[i][0]);
            }

           //fixed dimensions
            int[,] muliDimArray = {
               {1,2,3},
               {4,5,6},
               {7,8,9/*,10*/}
            };


            string[] towns = {"KBH", "AAB", "OD"};
            Index index1 = new Index();
            Index index2 = 1;
            Index index3 = ^1;
            Index index4 = ^2;
            var kbh = towns[index1];
            var aab = towns[index2];
            var OD = towns[index3];
            var alsoAab = towns[index4];
            /*Console.WriteLine(kbh);
            Console.WriteLine(aab);
            Console.WriteLine(OD);
            Console.WriteLine(alsoAab);
            Console.WriteLine("");*/

            Range firstTwo = 0..2;
            Range allButLast = index1..index3;
            string[] otherTowns = towns[allButLast];
            foreach(var town in otherTowns){
            //    Console.WriteLine(town);
            }


            Span<string> someTowns = towns[firstTwo];
               foreach(var town in someTowns){
               // Console.WriteLine(town);
            }
            



        }

        public static void add10(int[] nums){
           for (int i= 0; i < nums.Length; i++){
            nums[i]  += 10;
           }

        }
    }
}
