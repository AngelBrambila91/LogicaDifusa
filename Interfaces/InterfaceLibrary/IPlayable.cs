namespace InterfaceLibrary;

public interface IPlayable
{
    void Play();
    void Pause();
    void Stop() // Implementing default
    {
        Console.WriteLine("Default implementation of Stop.");
    }
}