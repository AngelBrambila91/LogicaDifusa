using MyOwnLibrary;
using Net7Library;

#region Angel Object
Person angel = new(); // Instance
angel.Name = "Angel";
angel.DateOfBirth = new DateTime(1991, 08, 02);
angel.NextDestination = PlacesToTravel.Sonora;
angel.BucketList = PlacesToTravel.Nerthelands | PlacesToTravel.Colombia;
// Index Formatting
WriteLine(format: "{0} was born on  {1:dddd, d MMMM yyyy}",
                    arg0: angel.Name,
                    arg1: angel.DateOfBirth);

WriteLine(format: " {0} Next Destination is : {1}. Its integer is {2}.",
                    arg0: angel.Name,
                    arg1: angel.NextDestination,
                    arg2: (int)angel.NextDestination);

// Interpolation
WriteLine($"{angel.Name}'s bucket list is {angel.BucketList}");

// Create a child to Angel
angel.Children.Add(new Person
{
    Name = "Alejandro"
});

angel.Children.Add(new Person
{
    Name = "Sofia"
});

WriteLine($"{angel.Name} has {angel.Children.Count} children.");
for (int childIndex = 0; childIndex < angel.Children.Count; childIndex++)
{
    WriteLine($"> {angel.Children[childIndex].Name}");
}

// Accessing a static field
BankAccount.InterestRate = 0.012M;
BankAccount newYorkLife = new();
newYorkLife.AccountName = "Miriam";
newYorkLife.Balance = 2500;

WriteLine(format: "{0} earned {1:C} interest.",
arg0: newYorkLife.AccountName,
arg1: newYorkLife.Balance * BankAccount.InterestRate);


// Using constant field
WriteLine($"{angel.Name} is a {Person.Species}");

// Using read only field
WriteLine($"{angel.Name} was born on {angel.HomePlanet}");
#endregion

#region Saul Object
// // creating a new person
// Person Saul = new()
// {
//     Name = "Saul",
//     DateOfBirth = new DateTime(1992, 02, 18),
//     NextDestination = PlacesToTravel.London,
//     BucketList = PlacesToTravel.Cancun | PlacesToTravel.Ireland
// };

// WriteLine(format: "{0} was born on  {1:dddd, d MMMM yyyy}",
//                     arg0: Saul.Name,
//                     arg1: Saul.DateOfBirth);

// WriteLine(format: " {0} Next Destination is : {1}. Its integer is {2}.",
// arg0: Saul.Name,
// arg1: Saul.NextDestination,
// arg2: (int)Saul.NextDestination);

// // Interpolation
// WriteLine($"{Saul.Name}'s bucket list is {Saul.BucketList}");
#endregion

#region Blank Person
// // Use of Constructor
Person blankPerson = new();
WriteLine(format: "{0} of  {1} was created at {2:hh:mm:ss} on a {2:dddd}",
arg0: blankPerson.Name,
arg1: blankPerson.HomePlanet,
arg2: blankPerson.Instantiated);
#endregion

#region Using Overloaded Constructor
Person Andrea = new(initialName: "Andrea", homePlanet: "Venus");
WriteLine(format: "{0} of  {1} was created at {2:hh:mm:ss} on a {2:dddd}",
 arg0: Andrea.Name,
 arg1: Andrea.HomePlanet,
 arg2: Andrea.Instantiated);
#endregion

#region Using Methods
// Using void method
angel.WriteToConsole();
// catch the return string
var origin = angel.GetOrigin();
Andrea.WriteToConsole();
WriteLine(Andrea.GetOrigin());
#endregion

#region Using Tuples
(string, int) fruit = angel.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are many");
var fruitAndrea = Andrea.GetFruit();
WriteLine($"There are {fruitAndrea.Number} {fruitAndrea.Name}");
#endregion

#region Passing Parameters
WriteLine(Andrea.SayHelloToPerson("Mayra"));
WriteLine(angel.SayHelloToPerson("Oscar", 4));
#endregion

#region Using Optional parameters
WriteLine(angel.OptionalParameters());
WriteLine(Andrea.OptionalParameters(command: "Jump!", number: 9.8));
#endregion

#region Passing Parameters
int a = 10;
int b = 20;
int c = 30;
WriteLine($"Before : a = {a}, b = {b}, c = {c}");
angel.PassingParameters(a, ref b, out c);
WriteLine($"After : a = {a}, b = {b}, c = {c}");
#endregion

#region Using the partial class
Person lucas = new()
{
    Name = "Lucas",
    DateOfBirth = new DateTime(1969, 6, 25)
};
WriteLine(lucas.Origin); // get
WriteLine(lucas.Greeting);
WriteLine(lucas.Age);

lucas.Favoritefood = "ENCHIlADAS"; // set
string? food = String.Empty;
try
{
    Write ("Give me a food : ");
    food = ReadLine();
    lucas.Favoritefood = food;
    WriteLine($"Lucas favorite food is {lucas.Favoritefood}");
}
catch (Exception ex)
{
    WriteLine($"Tried set {nameof(lucas.Favoritefood)} to {food} {ex.Message}");
}
#endregion

#region Using required set property
    Book book = new()
    {
        Isbn = "918-1892039201490",
        Title = "GoG",
        Author = "Giovanni Papini",
        Pagecount = 297
    };

    WriteLine($"{book.Isbn} : {book.Title} written by {book.Author} has {book.Pagecount}");

    Book leadership = new Book("911-323924139048903", "Awaken The leader in you");
    WriteLine($"{leadership.Isbn} : {leadership.Title} written by {leadership.Author} has {leadership.Pagecount}");
#endregion