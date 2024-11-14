namespace VariblesDemoCSharp_53;

class Program
{
    static void Main(string[] args)
    {
        //Variables
        //camelCase for variable names - everyOtherWordStartsWithCapital
        
        //Number types
        //Declaring a variable (creation of a variable)
        int wholeNumber;
        
        //Initializing a variable (giving it a value)
        wholeNumber = 5;
        
        //Or do both
        //Declaring and Initialzing
        int myAge = 30;

        double average = 98.7;

        decimal myAccount = 5000.00m;
        
        //Word types

        string ourClass = "CSharp-53";

        char initial = 'S';
        
        //Fact type

        bool isCoding = false;
        
        //string interpolation

        //string message = $"This class is {ourClass}!";

        //Console.WriteLine(message);
        
        //take user input

        Console.WriteLine("Give me your name:");
        
        string userInput = Console.ReadLine();

        //string message = $"Hello, {userInput}!";

        Console.WriteLine($"Hello, {userInput}!");
    }
}
