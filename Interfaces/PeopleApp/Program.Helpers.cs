using InterfaceLibrary;
using static System.Console;

partial class Program
{
    static void OutuputPeopleNames(IEnumerable<Person?> people, string title)
    {
        WriteLine(title);
        foreach (Person? p in people)
        {
            WriteLine("{0}",
                p is null ? "<null> Person" :  p.Name ?? "<null> Name");
        }   
    }
}