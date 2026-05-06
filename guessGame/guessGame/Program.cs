Random rand = new Random();
int guess = rand.Next(1, 101);
int userGuess;
int times = 1;
bool userChoice = true;

Console.WriteLine("Guess number between 1 to 100");

while (userChoice)
{
    if (!int.TryParse(Console.ReadLine(), out userGuess))
    {
        Console.WriteLine("Invalid Guess, Please guess numbers between 1 to 100");
        continue;
    }

    times++;

    if (userGuess == guess)
    {
        Console.WriteLine($"Contrazs. You guessed the correct number in {times} attampts.");

        Console.WriteLine("Do you want to play again? (y)");
        char choice;

        if (!char.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Byee....");
            break;
        }

        if (choice == 'y')
        {
            userChoice = true;
            Console.Clear();
            Console.WriteLine("Guess number between 1 to 100");
            guess = rand.Next(1, 101);
            times = 1;
        }
        else
        {
            break;
        }

    }
    else if (userGuess > guess)
    {
        Console.WriteLine("Try lower");
    }
    else if (userGuess < guess)
    {
        Console.WriteLine("Try higher");
    }




}