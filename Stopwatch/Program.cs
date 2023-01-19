using static System.Console;

Menu();

static void Menu()
{
    WriteLine("-----------StopWatch------------");
    WriteLine("S => Second => 10s = 10 seconds");
    WriteLine("M => Minute => 3m = 3 minutes");
    WriteLine("H => Hour => 7h = 7 hours");
    WriteLine("0 => Exit");
    WriteLine("How long do you wanna count?");

    string data = ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length - 1, 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));

    WriteLine(type);
    WriteLine(time);
    ReadLine();
}

static void Start()
{
    int time = 10;
    int currentTime = 0;

    while (currentTime != time)
    {
        Clear();
        currentTime++;
        WriteLine(currentTime);
        Thread.Sleep(1000);
    }
}