
public class Shearer : IVisitor
{
    private int wool;

    public void GetWool(int kg)
    {
        wool += kg;
    }

    public int ShowWool()
    {
        return wool;
    }
    
    public void visit(Cow animal)
    {
        Console.WriteLine($"I cannot shear {animal.GetType()}");
    }

    public void visit(Sheep animal)
    {
        Console.WriteLine($"I've sheared {animal.GetType()} and got 2kg of woool");
        GetWool(2);
    }

    public void visit(Pig animal)
    {
        Console.WriteLine($"I cannot shear {animal.GetType()}");
    }

    public void visit(Chicken animal)
    {
        Console.WriteLine($"I {typeof(Shearer)} visted {typeof(Chicken)}");
    }

    public void visit(Goat animal)
    {
        Console.WriteLine($"I {typeof(Shearer)} visted {typeof(Goat)}");
    }

    public void visit(Farm farm)
    {
        foreach(var location in farm.GetLocations())
        {
            location.accept(this);
        }
    }

    public void visit(Barn barn)
    {
        Console.WriteLine("I'm in a barn");
        foreach (var animals in barn.GetAnimals())
        {
            animals.accept(this);
        }
        Console.WriteLine("");
    }

    public void visit(Pen pen)
    {
       Console.WriteLine("There is no animal to shear in a pen\n");
    }

   public void visit(Field field)
    {
        Console.WriteLine("I'm in a field");
        foreach (var animals in field.GetAnimals())
        {
            animals.accept(this);
        }
        Console.WriteLine("");
    }
}