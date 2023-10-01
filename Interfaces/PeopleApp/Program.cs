using InterfaceLibrary;
using static System.Console;

#region Safe Project Reference Test
Person nicole = new()
{
    Name = "Nicolette",
    DateOfBirth = new(year: 2001, month: 9, day: 25)
};

nicole.WriteToConsole();
#endregion

#region Create HashTable non-Generic type
    System.Collections.Hashtable storageObjects = new();
    storageObjects.Add(key: 1, value:"Juno");
    storageObjects.Add(key: 2, value: "Nancy");
    storageObjects.Add(key: 3, value: "Pablito");
    storageObjects.Add(key: 4, value: "JorgeRicachon");
    storageObjects.Add(key: nicole, value: "Nicolette");

    int key = 2;
    WriteLine($"Key {key} has values : {storageObjects[key]}");
    // using object as key
    WriteLine($"Key {nicole} has values : {storageObjects[nicole]}");
#endregion

#region Dictionary Generic
    // T , U , -> generic Types
    System.Collections.Generic.Dictionary<int, string> genericStorage = new();
    genericStorage.Add(key: 1, value:"Juno");
    genericStorage.Add(key: 2, value: "Nancy");
    genericStorage.Add(key: 3, value: "Pablito");
    genericStorage.Add(key: 4, value: "JorgeRicachon");
    genericStorage.Add(key: 5, value: "Nicolette");

    int key2 = 5;
    WriteLine($"Key {key2} has values : {genericStorage[key2]}");
#endregion

#region Delegates
    int answer = nicole.MethodToCall("Suzuna");
    nicole.Shout += nicole_Shout;
    nicole.Shout += juno_Shout;

    nicole.Poke();
    nicole.Poke();
    nicole.Poke();
    nicole.Poke();

#endregion

#region Using IEnumerator
Person [] people = 
{
    new() {Name = null},
    new() { Name = "Hector" },
    new() { Name = "Nancy" },
    new() { Name = "Diana" },
    new() { Name = "Andrea" },
    new() { Name = "George" }
};
OutuputPeopleNames(people, "Initial List of people : ");
// simply use Sort
Array.Sort(people);
OutuputPeopleNames(people, "After sorting using IComparable implementation : ");
#endregion

#region Using Own Interface
// Call by reference
DvdPlayer dvd = new();
dvd.Play();
dvd.Pause();
#endregion

#region Testing different types of declarations for heap and stack
    int number1 = 30; // value type 32 Bytes
    long number2 = 10; // 8 bytes 
    System.Drawing.Point location = new(x:4, y:5); // value type
    Person juno = new() { Name = "Goretti", DateOfBirth = new DateTime(year: 2001, month:9, day:23) }; // Reference type
    Person dante = new() {Name = "Dante"}; // Refence type
#endregion