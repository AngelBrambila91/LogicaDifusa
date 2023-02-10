namespace MyOwnLibrary
{
    [Flags]
    public enum PlacesToTravel
    {
        None = 0b_0000_0000,
        Japan = 0b_0000_0001,
        Nerthelands = 0b_0000_0010,
        Ireland = 0b_0000_0100,
        London = 0b_0000_1000,
        Colombia = 0b_0001_0000,
        Cancun = 0b_0010_0000,
        Sonora = 0b_0100_0000
    }
}