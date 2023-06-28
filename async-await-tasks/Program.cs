

//Explicit task handling

/*var t1 = Task.Run(()=> {
    Console.WriteLine("Starting task1 ");
    Thread.Sleep(8000);
    Console.WriteLine("finished task1");
});

var t2 = Task.Run(()=> {
    Console.WriteLine("Starting task 2");
    Thread.Sleep(4000);
       Console.WriteLine("finished task2");
});

Task<int> addNum = Task.Run(()=> {
    return 3+5;
});

Console.WriteLine($"sum is {addNum.Result}");

Task.WaitAll(t1,t2);
*/


//implicit task handling
//can also add await before t3 execution or add .Wait after
t3();
Console.WriteLine("Running");
await findMeaningOfLife();
Thread.Sleep(10000);


static async Task t3 (){
    Console.WriteLine("Starting implicit task");
    await Task.Delay(5000);
    Console.WriteLine("Implicit task done");
}

static async Task findMeaningOfLife(){
    Console.WriteLine("Finding meaning of life");
    int result = await CalculateMeaningOfLife();
    Console.WriteLine($"Meaning of life is {result}");
}

static async Task<int> CalculateMeaningOfLife(){
    Console.WriteLine("Caluclation meaning of life");
    await Task.Delay(2000);
    return 42;
}