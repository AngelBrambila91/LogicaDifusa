namespace MyOwnLibrary
{
    // access modifier
    public class Person : Object
    {
        // Members
        // Fields
        public string? Name;
        public DateTime DateOfBirth;
        public PlacesToTravel NextDestination;
        public PlacesToTravel BucketList;

        // List<int>
        // List<string>
        public List<Person> Children = new ();
        // Constant
        public const string Species = "Homo Sapiens";
        // Read-only
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;
        // Event


        // Methods

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