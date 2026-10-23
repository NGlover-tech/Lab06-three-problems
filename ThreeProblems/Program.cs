
int numberImput;
Random rng = new Random(4000);
do
{
    System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");
    System.Console.WriteLine("1. the Grade Checker");
    System.Console.WriteLine("2. The Dice Table");
    System.Console.WriteLine("3. The Score Report");
    System.Console.WriteLine("4. All Three");
    System.Console.WriteLine("5. Quit");



do
    {
    System.Console.WriteLine("Choose 1 through 5: ");
        numberImput = Convert.ToInt32(Console.ReadLine());
    }while(numberImput != 1 && numberImput != 2 && numberImput != 3 && numberImput != 4 && numberImput != 5);

    if (numberImput == 1 || numberImput == 4)
    {
        // Exercise 1
        System.Console.WriteLine("=== Exercise 1: The Grade Checker ===");
        System.Console.WriteLine("Score: ");
        int score = Convert.ToInt32(Console.ReadLine());
        // While: The number of repeats beforehand is unknown so the user theoredically to repeat it infinite number of times
        while(score > 100 || score < 0)
        {
            System.Console.WriteLine("A score must be between 0 and 100");
            System.Console.WriteLine("Score: ");
            score = Convert.ToInt32(Console.ReadLine());
        }

        //Chain for the grades from highest to lowest
        if(score >= 90)
        {
            System.Console.WriteLine($"{score} earns a A");
        }
        else if(score >= 80)
        {
            System.Console.WriteLine($"{score} earns a B");
        }
        else if(score >= 70)
        {
            System.Console.WriteLine($"{score} earns a C");
        }
        else if(score >= 60)
        {
            System.Console.WriteLine($"{score} earns a D");
        }
        if(score < 60)
        {
            System.Console.WriteLine($"{score} earns a F");
        }
    }

    if (numberImput == 2 || numberImput == 4)
    {
        //Exercise 2
        System.Console.WriteLine("=== Exercise 2: The Dice Table ===");

        //Varibles for Dice
        int rollCount = 0;
        int winCount = 0;
        string playAgain;

        //Do-While: The player came to roll before being asked about rolling and the body must have to ran once before the question can be asked
        do
        {
            //Counts amount of rolls
            rollCount++;

            //Variables for the rolled dice and the sum of the 2 dice
            int die1 = rng.Next(1, 7);
            int die2 = rng.Next(1, 7);
            int dieTotal = die1 + die2;

            //When roll outputs snake eyes
            if (die1 == 1 && die2 == 1)
            {
                System.Console.WriteLine($"Roll {rollCount}: {die1} and {die2}, total {dieTotal}. Snake eyes");
            }

            //When roll outputs doubles
            else if (die1 == die2)
            {
                 System.Console.WriteLine($"Roll {rollCount}: {die1} and {die2}, total {dieTotal}. Doubles!");
            }

            //When roll outputs a winning number
            else if(dieTotal == 7 || dieTotal == 11)
            {
                 System.Console.WriteLine($"Roll {rollCount}: {die1} and {die2}, total {dieTotal}. Winner!");
                 winCount++;
            }
            
            //When roll outputs a result not above
            else if(dieTotal != 7 && dieTotal != 11)
            {
                 System.Console.WriteLine($"Roll {rollCount}: {die1} and {die2}, total {dieTotal}.");
            }

            //Ask for reroll
            System.Console.WriteLine("Roll again? (y/n): ");
            playAgain = Console.ReadLine();
        }while(playAgain == "y");

        //Total amount of rolls and the amount of times they won
        System.Console.WriteLine($"You rolled {rollCount} times and won {winCount}.");
    }

    if (numberImput == 3 || numberImput == 4)
    {
        // Exercise 3
    }

}while (numberImput !=5);

Console.WriteLine("Goodbye");