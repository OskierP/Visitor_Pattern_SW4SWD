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
        foreach(var location in farm.GetList())
        {
            location.accept(this);
        }
    }

    public void visit(Barn barn)
    {
        Console.WriteLine("I'm in a barn");
        foreach (var animals in barn.GetList())
        {
            animals.accept(this);
        }
        Console.WriteLine("");
    }

    public void visit(Pen pen)
    {
        Console.WriteLine("I'm in a pen");
        foreach (var animals in pen.GetList())
        {
            animals.accept(this);
        }
        Console.WriteLine("");
    }

    public void visit(Field field)
    {
        Console.WriteLine("I'm in a field");
        foreach (var animals in field.GetList())
        {
            animals.accept(this);
        }
        Console.WriteLine("");
    }
}