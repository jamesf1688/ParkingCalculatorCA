
Console.WriteLine("Parking Calculator");
Console.WriteLine("Parking costs £2 per hour");

bool runAgain = true;

// Keep the program running until the user wants to stop
while (runAgain)
{
    int hours = 0;
    bool valid = false;

    // Keep asking until valid hours are entered
    while (valid == false)
    {
        Console.WriteLine("Enter hours parked (0 to 24):");
        string? input = Console.ReadLine();

        // Check that the input is a whole number
        if (!int.TryParse(input, out hours))
        {
            Console.WriteLine("Please enter a whole number.");
        }
        // Check that the hours are between 0 and 24
        else if (hours < 0 || hours > 24)
        {
            Console.WriteLine("Please enter hours between 0 and 24.");
        }
        else
        {
            valid = true;
        }
    }

    // Calculate the parking charge at £2 per hour
    int cost = hours * 2;

    // Limit the maximum parking charge to £12
    if (cost > 12)
    {
        cost = 12;
    }

    // Display the result
    Console.WriteLine("Total parking cost: £" + cost);


    string? answer;

    // Keep asking until the user enters Y or N
    do
    {
        Console.WriteLine("Calculate another parking charge? (Y/N)");
        answer = Console.ReadLine()?.Trim().ToUpper();

        if (answer != "Y" && answer != "N")
        {
            Console.WriteLine("Please enter Y or N.");
        }

    } while (answer != "Y" && answer != "N");


    // Only close the program if the user enters N
    if (answer == "N")
    {
        runAgain = false;
    }
}

Console.WriteLine("Parking Calculator closed.");