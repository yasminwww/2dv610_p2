using System;

public interface IConsole 
{
    char ReadKey();
    string ReadLine();
    void WriteLine(string line);
}


public class RealConsole: IConsole
{
    public char ReadKey()
    {
        return Console.ReadKey().KeyChar;
    }

    public string ReadLine()
    {
        return Console.ReadLine();
    }

    public void WriteLine(string line)
    {
        Console.WriteLine(line);
    }
}

