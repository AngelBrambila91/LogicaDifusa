using InterfaceLibrary;

partial class Program
{
    // definition of Shout
    static void nicole_Shout(object? sender, EventArgs e)
    {
        if(sender is null) return;
        Person? p = sender as Person;
        if(p is null) return;
        System.Console.WriteLine($"{p.Name} is this anoyed {p.AnoyLevel}");
    }

    static void juno_Shout(object? sender, EventArgs e)
    {
        if(sender is null) return;
        Person? p = sender as Person;
        if(p is null) return;
        System.Console.WriteLine($"Juno says STOP IT! ARA ARA!!!!");
    }
}