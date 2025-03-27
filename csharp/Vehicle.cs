namespace csharp;

abstract class Vehicle
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

    public virtual void MakeSound()
    {
        Console.WriteLine("Vehicle Sound");
    }
}