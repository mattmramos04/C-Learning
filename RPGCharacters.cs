using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

public class RPGCharacters
{
    public string name ="";
    public string classType = "";
    public int level = 1;
    public static int characterCount = 0;

    public static void Main()
    {
        List<RPGCharacters> allCharacters = new List<RPGCharacters>();
        while (true)
        {
            RPGCharacters newCharacter = new RPGCharacters();

            newCharacter.AskForName();
            allCharacters.Add(newCharacter);
            newCharacter.CharacterClassChoice();
            newCharacter.DisplayInfo();

            Console.WriteLine("Want to create another character? (yes/no)");
            string again = Console.ReadLine();

            if (again.ToLower() != "yes")
            {
                break;
            }
        }

        RPGCharacters.CountCharacters();
    }

    private void AskForName()
    {
        Console.WriteLine("Enter your character's name:");
        string characterName = Console.ReadLine();
        name = characterName;
    }

    private void CharacterClassChoice()
    {
        Console.WriteLine("Choose a class (Warrior, Mage, Hunter):");
        string className = Console.ReadLine();

        if (className.ToLower() == "warrior")
        {
            classType = className;
            characterCount += 1;
        }
        else if (className.ToLower() == "mage")
        {
            classType = className;
            characterCount += 1;
        }
        else if (className.ToLower() == "hunter")
        {
            classType = className;
            characterCount += 1;
        }
        else
        {
            Console.WriteLine("Class doesn't exist!");
        }
    }

    private void DisplayInfo()
    {
        Console.WriteLine("Character Created!");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Class: {classType}");
        
    }

    private static void CountCharacters()
    {
        Console.WriteLine($"\nTotal characters created: {characterCount}");
    }
}