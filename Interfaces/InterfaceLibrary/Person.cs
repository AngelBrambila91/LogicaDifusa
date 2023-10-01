namespace InterfaceLibrary;
using static System.Console;

public class Person : Object , IComparable<Person>
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

    public int CompareTo(Person? other)
    {
        int position;
        if((this is not null) && (other is not null))
        {
            // if both Names values are not null call the Compare To Implementation
            if((Name is not null) && (other.Name is not null))
            {
                position = Name.CompareTo(other.Name);
            }
            else if((Name is not null) && (other.Name is null))
            {
                position = -1;
            }
            else if((Name is null) && (other.Name is not null))
            {
                position = 1;
            }
            else
            {
                position = 0;
            }
        }
        else if((this is not null) && (other is null))
        {
            position = -1;
        }
        else if((this is null) && (other is not null))
        {
            position = 1;
        }
        else
        {
            position = 0;
        }
        return position;
    }
}