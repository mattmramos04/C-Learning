using System;

public class Program
{
    /*public static void Main()
    {
        RunWrestlerTrainer(); 
    }
    
    public static void RunWrestlerTrainer()
    {
        bool playAgain = true;

        const int maxHealth = 100;
        int health = maxHealth;

        string wrestlerName = ShowWelcomeMessage();

        do
        {
            //We cast the parsed int number to pushups and then 
            int pushups = GetPushupCount();

            DoPushups(pushups);
            TakeBumps(health, wrestlerName);

            playAgain = AskToTrainAgain();
        }
        while (playAgain);
        ShowExitMessage(wrestlerName);
    }

    public static string ShowWelcomeMessage()
    {
        Console.WriteLine("Welcome to training! What's your name?");
        string input = Console.ReadLine();

        return input;
    }

    public static void ShowExitMessage(string wrestlerName)
    {
        Console.WriteLine($"Today was a good day of training {wrestlerName}. Now go get some rest you've earned it.");
    }

    public static int GetPushupCount()
    {
        int pushupCount;
        //While loop to make it ask continuously for integer(s) to answer the question
        while (true)
        {
            Console.WriteLine("How many pushups can you do?");
            //int pushupCount = int.Parse(Console.ReadLine()); working Parse from string to int but doesn't account for non numeric characters

            string rawInput = Console.ReadLine();

            if (int.TryParse(rawInput, out pushupCount))
            {
                break; //this stops the while loop, letting us exit
            }
            else
            {
                Console.WriteLine("That's not a number, please try again.");
            }
        }
        return pushupCount;
        //it will then return the parsed answer to the Console.WriteLine(). But how do I do that?
    }

    public static void DoPushups(int input)
    {
        for (int i = 1; i <= input; i++)
        {
            Console.WriteLine($"Pushup # {i}");
        }
    }

    public static void TakeBumps(int health, string wrestlerName)
    {
        while (health > 0)
        {
            Console.WriteLine($"{wrestlerName} can take a bump, how much damage do they take?");
            int bumpDamage = int.Parse(Console.ReadLine());
            health -= bumpDamage;

            if (health <= 0)
            {
                Console.WriteLine("Ouch! I'm done.");
            }
        }
    }

    public static bool AskToTrainAgain()
    {
        Console.WriteLine("Do you want to train again?");
        string askToPlay = Console.ReadLine();

        if (askToPlay.ToLower() == "n")
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    */
}