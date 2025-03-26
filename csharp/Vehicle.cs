namespace csharp;

public class Vehicle
{
    private string type = "Land";

    public string Type
    {
        get { return type; }
        set { type = value; }
    }
    
    public void DisplayType()
    {
        Console.WriteLine(type);
    }
}