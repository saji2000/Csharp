namespace csharp;

public class Vehicle
{
    private string type;

    public string Type
    {
        get { return type; }
        set { type = value; }
    }
    
    public void DisplayType()
    {
        Console.WriteLine(type);
    }

    public void MakeSound()
    {
        Console.WriteLine("Vehicle Sound");
    }
}