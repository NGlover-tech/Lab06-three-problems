
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
    }

    if (numberImput == 3 || numberImput == 4)
    {
        // Exercise 3
    }

}while (numberImput !=5);

Console.WriteLine("Goodbye");