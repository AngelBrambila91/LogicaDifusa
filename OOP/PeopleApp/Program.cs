using MyOwnLibrary;

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

// creating a new person
Person Saul = new()
{
    Name = "Saul",
    DateOfBirth = new DateTime(1992, 02, 18),
    NextDestination = PlacesToTravel.London,
    BucketList = PlacesToTravel.Cancun | PlacesToTravel.Ireland
};

WriteLine(format: "{0} was born on  {1:dddd, d MMMM yyyy}",
                    arg0: Saul.Name,
                    arg1: Saul.DateOfBirth);

WriteLine(format: " {0} Next Destination is : {1}. Its integer is {2}.",
arg0: Saul.Name,
arg1: Saul.NextDestination,
arg2: (int)Saul.NextDestination);

// Interpolation
WriteLine($"{Saul.Name}'s bucket list is {Saul.BucketList}");