System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");
System.Console.WriteLine("1. the Grade Checker");
System.Console.WriteLine("2. The Dice Table");
System.Console.WriteLine("3. The Score Report");
System.Console.WriteLine("4. All Three");
System.Console.WriteLine("5. Quit");

string numberImput;

do
{
    System.Console.WriteLine("Choose 1 through 5: ");
    numberImput = Console.ReadLine();
}while(numberImput != "1" && numberImput != "2" && numberImput != "3" && numberImput != "4" && numberImput != "5");