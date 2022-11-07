
public class Shearer : IWorker
{
    public void visit(Cow cow)
    {
        Console.WriteLine($"I {typeof(Shearer)} visted {typeof(Cow)}");
    }

    public void visit(Sheep sheep)
    {
        Console.WriteLine($"I {typeof(Shearer)} visted {typeof(Sheep)}");
    }

    public void visit(Pig pig)
    {
        Console.WriteLine($"I {typeof(Shearer)} visted {typeof(Pig)}");
    }

    public void visit(Chicken chicken)
    {
        Console.WriteLine($"I {typeof(Shearer)} visted {typeof(Chicken)}");
    }

    public void visit(Goat goat)
    {
        Console.WriteLine($"I {typeof(Shearer)} visted {typeof(Goat)}");
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
        foreach (var animals in barn.GetList())
        {
            animals.accept(this);
        }
    }

    public void visit(Pen pen)
    {
        foreach (var animals in pen.GetList())
        {
            animals.accept(this);
        }
    }

   public void visit(Field field)
    {
        foreach (var animals in field.GetList())
        {
            animals.accept(this);
        }
    }
}