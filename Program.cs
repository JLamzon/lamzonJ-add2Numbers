//Jessie Lamzon
//10/17/22
//GitHubChallenge - Redo all these mini Challenges
//Adding 2 numbers + data validation and option to play again

// Peer Review: Isaiah Keith Ferguson - Great and simple 
// program the best use of the try.parse i've seen for this challenge. 
// The only thing I might change is expanding the scope from 1-100 to maybe 
// the length of an int but other than that i really like the game! 




Console.Clear();

string playAgain = "y";


while (playAgain != "n")
{
    bool trueNumber;
    string stringNum1;
    string stringNum2;
    int intNumber1;
    int intNumber2;

    Console.WriteLine("Let's add some numbers!");
    Console.WriteLine("Type a number from 1 to 100");
    stringNum1 = Console.ReadLine();

    while (!int.TryParse(stringNum1, out intNumber1))
    {
        Console.WriteLine("Try again. Please enter your first number...");
        stringNum1 = Console.ReadLine();
    }
        Console.WriteLine("Let's pick another number from 1 - 100");
        stringNum2 = Console.ReadLine();

    while (!int.TryParse(stringNum2, out intNumber2))
    {
        Console.WriteLine("Try again. Please enter a second number...");
        stringNum2 = Console.ReadLine();
    }

    int totalSum = intNumber1 + intNumber2;
    Console.WriteLine($"The sum of those numbers equal to {totalSum}");
    
    while (playAgain != "n")
    {
        Console.WriteLine("Play again? type y or n");
        playAgain = Console.ReadLine();
        string playAgainLower = playAgain.ToLower();

        if (playAgainLower == "n")
        {
            Console.WriteLine("Thanks for playing!");
        }
        else if (playAgainLower == "y")
        {
            break;
        }

    }
}