public class TestConsole: IConsole
{
    public TestConsole(string fakeInputCharacters, string[] fakeInputStrings)
    {
        this.fakeInputCharacters = fakeInputCharacters;
        this.fakeInputStrings = fakeInputStrings;

    }
    private string fakeInputCharacters;
    private int ichar = 0;
    private string[] fakeInputStrings;
    private int istring = 0;
    private string output = "";

    public char ReadKey() 
    {
        return this.fakeInputCharacters[(this.ichar++) % this.fakeInputCharacters.Length];
    }

    public string ReadLine() 
    {
       return this.fakeInputStrings[(this.istring++) % this.fakeInputStrings.Length];
    }

    public void WriteLine(string line) 
    {
        this.output += (line + "\n");
    }

    public string GetOutput()
    {
        return output;
    }
}