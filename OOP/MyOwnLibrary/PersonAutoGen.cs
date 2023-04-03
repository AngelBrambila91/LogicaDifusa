namespace MyOwnLibrary;

public partial class Person
{
    // Detailed definition of a readonly property
    public string Origin
    {
        get
        {
            return string.Format($"{Name} was born on {HomePlanet}");
        }
    }
    
    // => lambda means return on get
    // short defintion of a property
    public string Greeting => $"{Name} says Hello";

    public int Age => DateTime.Today.Year - DateOfBirth.Year;

    private string? favoriteFood;
    public string? Favoritefood
    {
        get {
            return favoriteFood;
        }
        set
        {
            switch (value?.ToLower())
            {
                case "ramen":
                case "enchiladas":
                case "sandwich":
                    favoriteFood = value;
                    break;
                default:
                throw new ArgumentException(
                    $"{value} is not a food" +
                    "choose from: ramen, enchiladas or sandwich"
                );
            }
        }
    }

}