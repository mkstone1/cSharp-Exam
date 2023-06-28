public class Program
{
    public static void ShowMessage(string message)
    {
        Console.WriteLine("**************");
        Console.WriteLine(message);
        Console.WriteLine("**************");
    }

    public static void ShowBasicMessage(string message)
    {
        Console.WriteLine(message);
    }

    public delegate void MyDelegate(string message);

    static void Main(string[] args)
    {
        //return type and input type must match

        MyDelegate del = new MyDelegate(ShowMessage);

        //multicasting
        del += new MyDelegate(ShowBasicMessage);

        MyDelegate del2 = message => Console.WriteLine("Lamda delegate: " + message);

        //del2("hello lamda");

        //del("hello world");
        // del("Hello to you two");


       /* Engine car = new Engine();
        car.EngineStarted += () => Console.WriteLine("Engine started");
        car.StartEngine();

        car.EngineStopped += OnEngineStopped;
        car.EngineSpeedChange += OnSpeedChangeOne;

        car.setEngineSpeed(100);
        car.StopEngine();*/


    
    }

    public static void OnEngineStarted(){
        Console.WriteLine("Engine started");
    }

     public static void OnEngineStopped()
    {
        Console.WriteLine("The engine has stopped!");
    }

    public static void OnSpeedChangeOne(int speed)
    {
        Console.WriteLine($"The engine speed has changed to: {speed}");
    }
}

public class Engine
{
    public delegate void EngineStartHandler();
    public event EngineStartHandler EngineStarted;

    public delegate void EngineStopHandler();
    public event EngineStopHandler EngineStopped;

    public delegate void EngineSpeedChangeHandler(int speed);
    public event EngineSpeedChangeHandler EngineSpeedChange;

    private bool isEngineRunning;
    private int currentEngineSpeed;

    public void StartEngine()
    {
        isEngineRunning = true;
        EngineStarted?.Invoke();
    }

    public void StopEngine()
    {
        isEngineRunning = false;
        EngineStopped?.Invoke();
    }

    public void setEngineSpeed(int speed)
    {
        currentEngineSpeed = speed;
        EngineSpeedChange?.Invoke(speed);
    }
}
