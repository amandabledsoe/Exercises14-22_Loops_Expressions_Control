using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises14_22_Loops_Expressions_Control
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runningProgram = true;
            string userInput;
            bool isANumber;

            Console.WriteLine("Welcome to the program for Exercises 14 - 22 in the 2022 Grand Circus C# .Net boot camp.");
            Console.WriteLine("");
            while (runningProgram)
            {
                Console.WriteLine("Which exercise would you like to run?");
                Console.Write("Enter a number between 14 and 22 inclusive: ");
                userInput = Console.ReadLine();
                isANumber = int.TryParse(userInput, out int exerciseNumber);
                if (isANumber)
                {
                    if (exerciseNumber >= 14 && exerciseNumber <= 22)
                    {
                        Console.WriteLine("");
                        switch (exerciseNumber)
                        {
                            case 14:
                                Console.Clear();
                                DoExercise14();
                                break;
                            case 15:
                                Console.Clear();
                                DoExercise15();
                                break;
                            case 16:
                                Console.Clear();
                                DoExercise16();
                                break;
                            case 17:
                                Console.Clear();
                                DoExercise17();
                                break;
                            case 18:
                                Console.Clear();
                                DoExercise18();
                                break;
                            case 19:
                                Console.Clear();
                                DoExercise19();
                                break;
                            case 20:
                                Console.Clear();
                                DoExercise20();
                                break;
                            case 21:
                                Console.Clear();
                                DoExercise21();
                                break;
                            case 22:
                                Console.Clear();
                                DoExercise22();
                                break;
                        }
                        runningProgram = RunProgramAgainPrompt();
                    }
                    else if (exerciseNumber < 14 || exerciseNumber > 22)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Sorry, that number appears to be out of range. Please try again.");
                        Console.WriteLine("");
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Sorry, that doesnt appear to be a number. Please try again.");
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("This concludes Exercises 14 - 22 for the 2022 Grand Circus C# .Net boot camp.");
            Console.WriteLine("Goodbye...");
        }
        static bool RunProgramAgainPrompt()
        {
            bool promptingUser = true;
            while (promptingUser)
            {
                Console.WriteLine("Would you like to do another exercise?");
                Console.WriteLine("Enter 'y' or 'yes' to do another exercise, or enter 'n' or 'no' to exit the program.");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "y" || userInput == "yes")
                {
                    Console.WriteLine("");
                    Console.Clear();
                    promptingUser = false;
                    return true;
                }
                else if (userInput == "n" || userInput == "no")
                {
                    Console.WriteLine("");
                    Console.Clear();
                    promptingUser = false;
                    return false;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Sorry, I didn't understand that response. Please try again.");
                    Console.WriteLine("");
                    promptingUser = true;
                }
            }
            return false;
        }
        static void DoExercise14()
        {
            Console.WriteLine("EXERCISE 14:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Prompt the user for a number. Use a for loop to output the squares of all the numbers from 1 to that number.");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to begin this exercise.");
            Console.ReadLine();
            Console.Clear();

            bool doingExercise14 = true;
            while(doingExercise14)
            {
                bool gettingANumber = true;
                while(gettingANumber)
                {
                    Console.WriteLine("Enter a number a I will output the squares from that number to 1.");
                    Console.Write("Enter your number: ");
                    string response = Console.ReadLine();
                    bool isANumber = int.TryParse(response, out int number);
                    if (isANumber)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(String.Format("{0,0}{1,20}", "Your Number to 1", "Squared Values"));
                        Console.WriteLine("----------------------------------------");
                        for (int i = number; i >= 1; i--)
                        {
                            Console.WriteLine(String.Format("{0,8}{1,23}", i, i*i));
                        }
                        Console.WriteLine("");
                        gettingANumber = false;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Sorry, that doesnt appear to be a number. Let's try again.");
                        Console.WriteLine("");
                    }
                }

                bool askingUser = true;
                while (askingUser)
                {
                    Console.WriteLine("Would you like to do this exercise again?");
                    Console.Write("Enter 'y' or 'yes' to run again, or enter 'n' or 'no' to stop: ");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "y" || answer == "y")
                    {
                        Console.WriteLine("");
                        askingUser = false;
                        doingExercise14 = true;
                    }
                    else if (answer == "n" || answer == "no")
                    {
                        askingUser = false;
                        doingExercise14 = false;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("I'm sorry, I didn't understand that response. Please try again.");
                        Console.WriteLine("");
                        askingUser = true;
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            Console.Clear();
        }
        static void DoExercise15()
        {
            Console.WriteLine("EXERCISE 15:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Prompt the user for a number. Use a for loop to output the cubes of all the numbers from 1 to that number.");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to begin this exercise.");
            Console.ReadLine();
            Console.Clear();

            bool doingExercise15 = true;
            while (doingExercise15)
            {
                bool gettingANumber = true;
                while (gettingANumber)
                {
                    Console.WriteLine("Enter a number a I will output the cubes from 1 to that number.");
                    Console.Write("Enter your number: ");
                    string response = Console.ReadLine();
                    bool isANumber = int.TryParse(response, out int number);
                    if (isANumber)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(String.Format("{0,0}{1,20}", "1 to Your Number", "Cubed Values"));
                        Console.WriteLine("----------------------------------------");
                        for (int i = 1; i <= number; i++)
                        {
                            Console.WriteLine(String.Format("{0,8}{1,22}", i, i*i*i));
                        }
                        Console.WriteLine("");
                        gettingANumber = false;
                    }

                    bool askingUser = true;
                    while (askingUser)
                    {
                        Console.WriteLine("Would you like to do this exercise again?");
                        Console.Write("Enter 'y' or 'yes' to run again, or enter 'n' or 'no' to stop: ");
                        string answer = Console.ReadLine().ToLower();
                        if (answer == "y" || answer == "y")
                        {
                            Console.WriteLine("");
                            askingUser = false;
                            doingExercise15 = true;
                        }
                        else if (answer == "n" || answer == "no")
                        {
                            askingUser = false;
                            doingExercise15 = false;
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("I'm sorry, I didn't understand that response. Please try again.");
                            Console.WriteLine("");
                            askingUser = true;
                        }
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            Console.Clear();
        }
        static void DoExercise16()
        {
            Console.WriteLine("EXERCISE 16:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Use a for loop to output a triangle of asterisks with a height of ten.");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to begin this exercise.");
            Console.ReadLine();
            Console.Clear();

            bool doingExercise16 = true;
            while (doingExercise16)
            {
                Console.WriteLine("Below is a 10-row triangle of asterisks:");
                Console.WriteLine("");

                for (int i = 0; i < 10; i++)
                {
                    for (int num = 1; num < 2 + i; num++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("");

                bool askingUser = true;
                while (askingUser)
                {
                    Console.WriteLine("Would you like to do this exercise again?");
                    Console.Write("Enter 'y' or 'yes' to run again, or enter 'n' or 'no' to stop: ");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "y" || answer == "y")
                    {
                        Console.WriteLine("");
                        askingUser = false;
                        doingExercise16 = true;
                    }
                    else if (answer == "n" || answer == "no")
                    {
                        askingUser = false;
                        doingExercise16 = false;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("I'm sorry, I didn't understand that response. Please try again.");
                        Console.WriteLine("");
                        askingUser = true;
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            Console.Clear();
        }
        static void DoExercise17()
        {
            Console.WriteLine("EXERCISE 17:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Use a for loop to output a triangle of asterisks with a height of ten.");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to begin this exercise.");
            Console.ReadLine();
            Console.Clear();

            bool doingExercise17 = true;
            while (doingExercise17)
            {
                Console.WriteLine("Below is a 10-row pyramid of asterisks:");
                Console.WriteLine("");

                int i, j, k;
                int rows = 10;
                int spc = rows + 4 - 1;
                for (i = 1; i <= rows; i++)
                {
                    for (k = spc; k >= 1; k--)
                    {
                        Console.Write(" ");
                    }

                    for (j = 1; j <= i; j++)
                        Console.Write("* ");
                    Console.Write("\n");
                    spc--;
                }
                Console.WriteLine("");

                bool askingUser = true;
                while (askingUser)
                {
                    Console.WriteLine("Would you like to do this exercise again?");
                    Console.Write("Enter 'y' or 'yes' to run again, or enter 'n' or 'no' to stop: ");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "y" || answer == "y")
                    {
                        Console.WriteLine("");
                        askingUser = false;
                        doingExercise17 = true;
                    }
                    else if (answer == "n" || answer == "no")
                    {
                        askingUser = false;
                        doingExercise17 = false;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("I'm sorry, I didn't understand that response. Please try again.");
                        Console.WriteLine("");
                        askingUser = true;
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            Console.Clear();
        }
        static void DoExercise18()
        {
            Console.WriteLine("EXERCISE 18:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Prompt the user to enter a number. Use a for-loop to calculate the sum of all the numbers from 1 to the number entered.");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to begin this exercise.");
            Console.ReadLine();
            Console.Clear();

            bool doingExercise18 = true;
            while (doingExercise18)
            {
                bool gettingANumber = true;
                while (gettingANumber)
                {
                    List<int> numbers = new List<int>();
                    Console.WriteLine("Enter a number and I will calculate the sum of all of the numbers from 1 to your number.");
                    Console.Write("Enter your number: ");
                    string response = Console.ReadLine();
                    bool isANumber = int.TryParse(response, out int number);
                    if (isANumber)
                    {
                        for (int i = 0; i <= number; i++)
                        {
                            numbers.Add(i);
                        }
                        Console.WriteLine("");
                        Console.Write($"The sum of all of the numbers from 1 to {number} is: ");
                        Console.WriteLine(numbers.Sum());
                        Console.WriteLine("");
                        gettingANumber = false;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Sorry, that doesnt appear to be a number. Let's try again.");
                        Console.WriteLine("");
                    }
                }

                bool askingUser = true;
                while (askingUser)
                {
                    Console.WriteLine("Would you like to do this exercise again?");
                    Console.Write("Enter 'y' or 'yes' to run again, or enter 'n' or 'no' to stop: ");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "y" || answer == "y")
                    {
                        Console.WriteLine("");
                        askingUser = false;
                        doingExercise18 = true;
                    }
                    else if (answer == "n" || answer == "no")
                    {
                        askingUser = false;
                        doingExercise18 = false;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("I'm sorry, I didn't understand that response. Please try again.");
                        Console.WriteLine("");
                        askingUser = true;
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            Console.Clear();
        }
        static void DoExercise19()
        {
            Console.WriteLine("EXERCISE 19:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Prompt the user to enter two numbers. Use a for-loop to calculate the sum of all the numbers from the first number entered to the second.");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to begin this exercise.");
            Console.ReadLine();
            Console.Clear();

            bool doingExercise19 = true;
            while (doingExercise19)
            {
                int number1;
                int number2;
                List<int> numbers = new List<int>();
                bool gettingFirstNumber = true;
                while (gettingFirstNumber)
                {
                    Console.WriteLine("Enter two numbers and I will calculate the sum of all of the numbers from your first number to your second number.");
                    Console.Write("Enter your first number: ");
                    string response = Console.ReadLine();
                    bool isANumber = int.TryParse(response, out int numberEntry1);
                    if (isANumber)
                    {
                        number1 = numberEntry1;

                        bool gettingSecondNumber = true;
                        while (gettingSecondNumber)
                        {
                            Console.Write("Enter your second number: ");
                            string response2 = Console.ReadLine();
                            bool isANumber2 = int.TryParse(response2, out int numberEntry2);
                            if (isANumber2)
                            {
                                number2 = numberEntry2;

                                if(number1 > number2)
                                {
                                    for (int i = number2; i <= number1; i++)
                                    {
                                        numbers.Add(i);
                                    }
                                    Console.WriteLine("");
                                    Console.Write($"The sum of the numbers from {number2} to {number1} is: ");
                                    Console.WriteLine(numbers.Sum());
                                    Console.WriteLine("");
                                }
                                else
                                {
                                    for (int i = number1; i <= number2; i++)
                                    {
                                        numbers.Add(i);
                                    }
                                    Console.WriteLine("");
                                    Console.Write($"The sum of the numbers from {number1} to {number2} is: ");
                                    Console.WriteLine(numbers.Sum());
                                    Console.WriteLine("");
                                }
                                gettingSecondNumber = false;
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Sorry, that doesnt appear to be a number. Let's try again.");
                                Console.WriteLine("");
                            }
                        }
                        gettingFirstNumber = false;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Sorry, that doesnt appear to be a number. Let's try again.");
                        Console.WriteLine("");
                    }
                }

                bool askingUser = true;
                while (askingUser)
                {
                    Console.WriteLine("Would you like to do this exercise again?");
                    Console.Write("Enter 'y' or 'yes' to run again, or enter 'n' or 'no' to stop: ");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "y" || answer == "y")
                    {
                        Console.WriteLine("");
                        askingUser = false;
                        doingExercise19 = true;
                    }
                    else if (answer == "n" || answer == "no")
                    {
                        askingUser = false;
                        doingExercise19 = false;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("I'm sorry, I didn't understand that response. Please try again.");
                        Console.WriteLine("");
                        askingUser = true;
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            Console.Clear();
        }
        static void DoExercise20()
        {
            Console.WriteLine("EXERCISE 20:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Prompt the user to enter a number. Use a for-loop to calculate the product of the number and the two preceding numbers.");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to begin this exercise.");
            Console.ReadLine();
            Console.Clear();

            List<int> numbers = new List<int>();
            bool doingExercise20 = true;
            while (doingExercise20)
            {
                bool gettingANumber = true;
                while (gettingANumber)
                {
                    Console.WriteLine("Enter a number and I will calculate the product that number, the preceding number, and the preceding number before that.");
                    Console.Write("Enter your number: ");
                    string response = Console.ReadLine();
                    Console.WriteLine("");
                    bool isANumber = int.TryParse(response, out int number);
                    if (isANumber)
                    {
                        for (int i = number; i >= (number-2); i--)
                        {
                            numbers.Add(i);
                        }
                        Console.WriteLine("");
                        Console.WriteLine($"The product of {number}, {number-1}, and {number-2} is: {numbers.Aggregate((a, x) => a * x)}");
                        Console.WriteLine("");
                        numbers.Clear();
                        gettingANumber = false;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Sorry, that doesnt appear to be a number. Let's try again.");
                        Console.WriteLine("");
                    }
                }

                bool askingUser = true;
                while (askingUser)
                {
                    Console.WriteLine("Would you like to do this exercise again?");
                    Console.Write("Enter 'y' or 'yes' to run again, or enter 'n' or 'no' to stop: ");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "y" || answer == "y")
                    {
                        Console.WriteLine("");
                        askingUser = false;
                        doingExercise20 = true;
                    }
                    else if (answer == "n" || answer == "no")
                    {
                        askingUser = false;
                        doingExercise20 = false;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("I'm sorry, I didn't understand that response. Please try again.");
                        Console.WriteLine("");
                        askingUser = true;
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            Console.Clear();
        }
        static void DoExercise21()
        {
            Console.WriteLine("EXERCISE 21:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Prompt the user to enter a series of words. Once the user is done entering the words, output a sentence containing all the words.");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to begin this exercise.");
            Console.ReadLine();
            Console.Clear();

            List<string> words = new List<string>();
            bool doingExercise21 = true;
            while (doingExercise21)
            {
                Console.WriteLine("Enter a series of words and, once complete, I will put them into a sentence.");
                Console.WriteLine("");

                bool gatheringWords = true;
                while(gatheringWords)
                {
                    Console.Write("Enter your word: ");
                    string enteredWord = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(enteredWord) && words.Count == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("We've got to have at least one word to print out a sentence. Please try again.");
                        Console.WriteLine("");
                    }
                    else if (string.IsNullOrWhiteSpace(enteredWord) && words.Count() > 0)
                    {
                        words.RemoveAt(words.Count()-1);
                        Console.WriteLine("");
                        for (int i = words.Count(); i <= words.Count(); i++)
                        {
                            foreach (var item in words)
                            {
                                Console.Write($"{item}");
                            }
                        }
                        Console.Write(".");
                        Console.WriteLine("");
                        words.Clear();
                        gatheringWords = false;
                    }
                    else if (string.IsNullOrWhiteSpace(enteredWord) != true)
                    {
                        words.Add(enteredWord);
                        words.Add(" ");
                        Console.WriteLine("");
                    }
                }
                Console.WriteLine("");
                bool askingUser = true;
                while (askingUser)
                {
                    Console.WriteLine("Would you like to do this exercise again?");
                    Console.Write("Enter 'y' or 'yes' to run again, or enter 'n' or 'no' to stop: ");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "y" || answer == "y")
                    {
                        Console.WriteLine("");
                        askingUser = false;
                        doingExercise21 = true;
                    }
                    else if (answer == "n" || answer == "no")
                    {
                        askingUser = false;
                        doingExercise21 = false;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("I'm sorry, I didn't understand that response. Please try again.");
                        Console.WriteLine("");
                        askingUser = true;
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            Console.Clear();
        }
        static void DoExercise22()
        {
            Console.WriteLine("EXERCISE 22:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Prompt the user to enter two numbers that will determine a range. Then prompt the user to enter another number and check if it is in the range.");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to begin this exercise.");
            Console.ReadLine();
            Console.Clear();

            bool doingExercise22 = true;
            while (doingExercise22)
            {
                int number1;
                int number2;
                int number3;
                bool gettingFirstNumber = true;
                while (gettingFirstNumber)
                {
                    Console.WriteLine("Enter two numbers, which will become our range. Then, enter a third number and I'll tell you if number 3 is in that range.");
                    Console.Write("Enter your first number: ");
                    string response = Console.ReadLine();
                    bool isANumber = int.TryParse(response, out int numberEntry1);
                    if (isANumber)
                    {
                        number1 = numberEntry1;

                        bool gettingSecondNumber = true;
                        while (gettingSecondNumber)
                        {
                            Console.Write("Enter your second number: ");
                            string response2 = Console.ReadLine();
                            bool isANumber2 = int.TryParse(response2, out int numberEntry2);
                            if (isANumber2)
                            {
                                number2 = numberEntry2;
                                bool gettingThirdNumber = true;
                                while(gettingThirdNumber)
                                {
                                    Console.WriteLine("");
                                    if (number1 > number2)
                                    {
                                        Console.WriteLine($"Our range is between {number2} and {number1}.");
                                        Console.Write("Now, enter your third number: ");
                                        string response3 = Console.ReadLine();
                                        bool isANumber3 = int.TryParse(response3, out int numberEntry3);
                                        if (isANumber3)
                                        {
                                            number3 = numberEntry3;
                                            if (number3 >= number2 && number3 <= number1)
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine($"Your third number, {number3}, IS in the range of your first two numbers, {number2} and {number1}.");
                                                Console.WriteLine("");
                                                gettingThirdNumber = false;
                                            }
                                            else if (number3 < number2 || number3 > number1)
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine($"Your third number, {number3}, IS NOT in the range of your first two numbers, {number2} and {number1}.");
                                                Console.WriteLine("");
                                                gettingThirdNumber = false;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Sorry, that doesnt appear to be a number. Let's try again.");
                                            Console.WriteLine("");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Our range is between {number1} and {number2}.");
                                        Console.Write("Now, enter your third number: ");
                                        string response3 = Console.ReadLine();
                                        bool isANumber3 = int.TryParse(response3, out int numberEntry3);
                                        if (isANumber3)
                                        {
                                            number3 = numberEntry3;
                                            if (number3 >= number1 && number3 <= number2)
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine($"Your third number, {number3}, IS in the range of your first two numbers, {number1} and {number2}.");
                                                Console.WriteLine("");
                                                gettingThirdNumber = false;
                                            }
                                            else if (number3 < number1 || number3 > number2)
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine($"Your third number, {number3}, IS NOT in the range of your first two numbers, {number1} and {number2}.");
                                                Console.WriteLine("");
                                                gettingThirdNumber = false;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Sorry, that doesnt appear to be a number. Let's try again.");
                                            Console.WriteLine("");
                                        }
                                    }
                                }
                                gettingSecondNumber = false;
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Sorry, that doesnt appear to be a number. Let's try again.");
                                Console.WriteLine("");
                            }
                        }
                        gettingFirstNumber = false;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Sorry, that doesnt appear to be a number. Let's try again.");
                        Console.WriteLine("");
                    }
                }

                bool askingUser = true;
                while (askingUser)
                {
                    Console.WriteLine("Would you like to do this exercise again?");
                    Console.Write("Enter 'y' or 'yes' to run again, or enter 'n' or 'no' to stop: ");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "y" || answer == "y")
                    {
                        Console.WriteLine("");
                        askingUser = false;
                        doingExercise22 = true;
                    }
                    else if (answer == "n" || answer == "no")
                    {
                        askingUser = false;
                        doingExercise22 = false;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("I'm sorry, I didn't understand that response. Please try again.");
                        Console.WriteLine("");
                        askingUser = true;
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
