
using System.Runtime.Serialization;

int GetNumberFromUser()
{
    int number = 0;
    while (number < 1 || number > 10)
    {
        Console.WriteLine("Enter a number between 1 and 10: ");
        string? response = Console.ReadLine();
        try
        {
            number = Convert.ToInt32(response);

        }
        catch (FormatException e)
        {
            number = -1;
            Console.WriteLine($"I do not understand '{response}'");
            Console.WriteLine(e.Message);
        }
        catch (OverflowException)
        {
            number = -1;
            Console.WriteLine($"That number is too big");
        }
    }
    return number;
}
Console.WriteLine("Name an animal: ");
string? animal = Console.ReadLine();
if (animal == "Snake")
{
    throw new NotSupportedException("I have ophidiophobia");
}
public class Snakexception : Exception
{
    public Snakexception()
    {

    }

    public Snakexception(string message) : base(message)
    {
        try
        {
            Console.WriteLine("Shall we play a game?");
            if (Console.ReadLine() == "no") return;
            Console.WriteLine("Name an animal.");
            string? animal = Console.ReadLine();
            if (animal == "snake") throw new Snakexception();
        }
        catch (Snakexception) { Console.WriteLine("Why did it have to be snakes?"); }
        finally
        {
            Console.WriteLine("We are all done here");

        }
        
    }
}
