namespace Visitor_Pattern_SW4SWD.Workers;

public class Butcher : IVisitor
{
    public void visit(Cow animal)
    {
        Console.WriteLine($"I've butchered {animal.GetType().ToString().ToLower()}");
    }

    public void visit(Sheep animal)
    {
        Console.WriteLine($"I've butchered {animal.GetType().ToString().ToLower()}");
    }

    public void visit(Pig animal)
    {
        Console.WriteLine($"I've butchered {animal.GetType().ToString().ToLower()}");
    }

    public void visit(Chicken animal)
    {
        Console.WriteLine($"I've butchered {animal.GetType().ToString().ToLower()}");
    }

    public void visit(Goat animal)
    {
        Console.WriteLine($"I've butchered {animal.GetType().ToString().ToLower()}");
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
        Console.WriteLine("I'm in a pen");
        foreach (var animals in pen.GetAnimals())
        {
            animals.accept(this);
        }
        Console.WriteLine("");
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