using static System.Console;

Menu();

static void Menu()
{
    Clear();

    Console.ForegroundColor
    = ConsoleColor.Blue;
    WriteLine("-----------------------Calculator-------------------------------");
    WriteLine("1 - Calculate");
    WriteLine("2 - Subtract");
    WriteLine("3 - Divide");
    WriteLine("4 - Multiply");
    WriteLine("5 - Exit");
    WriteLine("----------------------------------------------------------------");
    WriteLine("");

    bool optionValid = short.TryParse(ReadLine(), out short option);

    if (optionValid)
    {

        Console.ForegroundColor
              = ConsoleColor.Gray;

        switch (option)
        {
            case 1: Sum(); break;
            case 2: Sub(); break;
            case 3: Div(); break;
            case 4: Mult(); break;
            case 5: System.Environment.Exit(0); break;
            default: Menu(); break;
        }
    }
    else
    {
        Console.ForegroundColor
       = ConsoleColor.Red;

        WriteLine("Please enter a valid option");

        WriteLine("");

        Console.ForegroundColor
       = ConsoleColor.Yellow;
        WriteLine("Enter to return to the Menu");
        ReadKey();
        Menu();
    }
}

static void Sum()
{
    WriteLine("What your first number?");
    float n1 = float.Parse(ReadLine());
    WriteLine("");
    WriteLine("And your second number?");
    float n2 = float.Parse(ReadLine());

    Console.ForegroundColor
       = ConsoleColor.Green;

    WriteLine($"Your result is {n1 + n2}");
    ReadKey();
    Menu();
}

static void Sub()
{
    WriteLine("What your first number?");
    float n1 = float.Parse(ReadLine());
    WriteLine("");
    WriteLine("And your second number?");
    float n2 = float.Parse(ReadLine());

    Console.ForegroundColor
          = ConsoleColor.Green;
    WriteLine($"Your result is {n1 - n2}");
    ReadKey();
    Menu();
}

static void Div()
{
    WriteLine("What your first number?");
    float n1 = float.Parse(ReadLine());
    WriteLine("");
    WriteLine("And your second number?");
    float n2 = float.Parse(ReadLine());

    Console.ForegroundColor
          = ConsoleColor.Green;

    WriteLine($"Your result is {n1 / n2}");
    ReadKey();
    Menu();
}

static void Mult()
{
    WriteLine("What your first number?");
    float n1 = float.Parse(ReadLine());
    WriteLine("");
    WriteLine("And your second number?");
    float n2 = float.Parse(ReadLine());

    Console.ForegroundColor
          = ConsoleColor.Green;

    WriteLine($"Your result is {n1 * n2}");
    ReadKey();
    Menu();
}



