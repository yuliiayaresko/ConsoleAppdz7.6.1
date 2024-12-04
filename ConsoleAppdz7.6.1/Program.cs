class Program
{
    static void Main(string[] args)
    {
        Developer dev = new FKNKDeveloper("УкрБут");
        House house2 = dev.Create();

        dev = new FREKSDeveloper("БутБут");
        House house = dev.Create();

        Console.ReadLine();
    }
}

abstract class Developer
{
    public string Name { get; set; }

    public Developer(string n)
    {
        Name = n;
    }
   
    abstract public House Create();
}

class FKNKDeveloper : Developer
{
    public FKNKDeveloper(string n) : base(n)
    { }

    public override House Create()
    {
        return new FKNKHouse();
    }
}

class FREKSDeveloper : Developer
{
    public FREKSDeveloper(string n) : base(n)
    { }

    public override House Create()
    {
        return new FREKSHouse();
    }
}

abstract class House
{ }

class FKNKHouse : House
{
    public FKNKHouse()
    {
        Console.WriteLine("ФКНК збудували");
    }
}
class FREKSHouse : House
{
    public FREKSHouse()
    {
        Console.WriteLine("ФРЕКС збудували ");
    }
}