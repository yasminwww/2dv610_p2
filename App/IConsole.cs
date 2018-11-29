using System;

public interface IConsole 
{
    char ReadKey();

    void WriteLine(string line);
}


public class RealConsole: IConsole
{
    public char ReadKey()
    {
        return Console.ReadKey().KeyChar;
    }

    public void WriteLine(string line)
    {
        Console.WriteLine(line);
    }
}

