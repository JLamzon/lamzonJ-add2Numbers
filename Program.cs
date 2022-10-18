//Jessie Lamzon
//10/17/22
//GitHubChallenge - Redo all these mini Challenges
//data validation and option to play again




Console.Clear();

string myName = "yes";

while (myName != "no")
{
    Console.WriteLine("Let's add some numbers!");
    Console.WriteLine("Type a number from 1 to 100");
    string num1 = Console.ReadLine();
    Console.WriteLine("Let's pick another number from 1 - 100");
    string num2 = Console.ReadLine();

    int number1 = Convert.ToInt32(num1);
    int number2 = Convert.ToInt32(num2);

    Console.WriteLine("The sum of those numbers equal to " + (number1 + number2));
    
    Console.WriteLine("Do you want to play again? Type yes or no");
    myName = Console.ReadLine();
}

Console.WriteLine("Thanks for Playing!");