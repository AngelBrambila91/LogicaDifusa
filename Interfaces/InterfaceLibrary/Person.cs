namespace InterfaceLibrary;
using static System.Console;

public class Person : Object
{
    // properties
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {DateOfBirth:dddd}");
    }

    public int MethodToCall(string input)
    {
        return input.Length;
    }

    // Delegates have always 2 parameters
    // object? sender : This is the object who has the reference of the delegate
    // EventArgs e TEventargs: Additional info

    // delegate field
    public event EventHandler? Shout;
    // data
    public int AnoyLevel;
    // method
    public void Poke()
    {
        AnoyLevel++;
        if(AnoyLevel >= 3)
        {
            // if something is called by the listener
            if(Shout != null)
            {
               Shout(this, EventArgs.Empty);
            }
        }
    }
}