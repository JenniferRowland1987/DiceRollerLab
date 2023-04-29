using System.ComponentModel.Design;
static int DieRoll(int sides)
{
    Random rnd = new Random();
    int result = rnd.Next(1, sides);
    return result;
}

static string sixSideMatchRoll (int rollOne, int rollTwo)
{
    
    if (rollOne == 1 && rollTwo == 1)
    {
        return "Snake eyes";
    }
    else if ((rollOne + rollTwo) == 3)
    {
        return "Ace Duce";
    }
    else if (rollOne == 6 && rollTwo == 6)
    {
        return "Box Cars";
    }
    else
    {
        return "...";
    }
}

static string sixSideCrapsRoll (int rollOne, int rollTwo)
{
    int[] win = new int[] { 7, 11 };
    int[] craps = new int[] { 2, 3, 12 };

    if (win.Contains(rollOne + rollTwo))
    {
        return $"{rollOne + rollTwo}, win!";
    }
    else if (craps.Contains(rollOne + rollTwo))
    {
        return $"{rollOne + rollTwo}, craps!";
    }
    else
    {
        return "...";
    }
}


while (true)
{
    Console.WriteLine("Welcome to the Dice Rolling Game of Rolling Dice");
    Console.WriteLine("How many sides would you like your dice to have?");
    int dieSides = int.Parse(Console.ReadLine());
    if (dieSides <= 0)
    {
        Console.WriteLine("that is not a valid number of sides");
        continue;
    }

        while (dieSides == 6) 
        {
        int rollOne = DieRoll(6);
        int rollTwo = DieRoll(6);
        Console.WriteLine("Let's roll!");
        Console.WriteLine($"First roll is ... {rollOne}");
        Console.WriteLine($"Second roll is ... {rollTwo}");
        Console.WriteLine(sixSideMatchRoll(rollOne, rollTwo));
        Console.WriteLine(sixSideCrapsRoll(rollOne, rollTwo));
        Console.WriteLine("Would you like to roll again (y/n)? Or to change number of sides press enter");
        string rollAgain = Console.ReadLine().ToLower();
            if (rollAgain == "y")
            {
            continue;
            }
            else if(rollAgain == "n")
            {
                return;
            }
            else if(rollAgain == "")
            {
                break;
            }              
        }
        while (dieSides != 6)  
        {
        int rollOne = DieRoll(dieSides);
        int rollTwo = DieRoll(dieSides);
        Console.WriteLine("Let's roll!");
        Console.WriteLine($"First roll is ... {rollOne}");
        Console.WriteLine($"Second roll is ... {rollTwo}");
        Console.WriteLine("Would you like to roll again (y/n)? Or to change number of sides press enter");
        string rollAgain = Console.ReadLine().ToLower();
        if (rollAgain == "y")
        {
            continue;
        }
        else if (rollAgain == "n")
        {
            return;
        }
        else if (rollAgain == "")
        {
            break;
        }
    }
   
}

