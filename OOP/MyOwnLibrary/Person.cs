namespace MyOwnLibrary
{
    // access modifier
    public partial class Person : Object
    {
        // Members
        // Fields
        public string? Name;
        public DateTime DateOfBirth;
        public PlacesToTravel NextDestination;
        public PlacesToTravel BucketList;

        // List<int>
        // List<string>
        public List<Person> Children = new();
        // Constant
        public const string Species = "Homo Sapiens";
        // Read-only
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;
        // Event


        // Methods
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}";
        }

        //Tuples
        public (string Name, int Number) GetFruit()
        {
            return (Name: "Oranges", Number: 5);
        }

        // Passing Parameters
        public string SayHelloToPerson(string name)
        {
            return $"{Name} says 'Hello, {name}'";
        }

        public string SayHelloToPerson(string name, int number)
        {
            return $"{Name} count {number} for your friend {name}";
        }

        public string OptionalParameters(string command = "Shout!", double number = 0.0, bool active = true)
        {
            return string.Format(format: "command is {0} , number is {1}, active is {2}",
            arg0: command,
            arg1: number,
            arg2: active);
        }

        // Passing Parameters
        public void PassingParameters(int x, ref int y, out int z)
        {
            // out cannot have a default
            // out NEEDS a value INSIDE the method
            z = 99;
            x ++;
            y++;
            z++;
        }
        // Constructor
        public Person()
        {
            Name = "Unkwown";
            Instantiated = DateTime.Now;
        }
        // Overload Contructor
        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }
        // Property

        // Indexer

        // Operator
    }
}