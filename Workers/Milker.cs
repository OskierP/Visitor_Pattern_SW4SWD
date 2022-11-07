namespace Visitor_Pattern_SW4SWD.Workers;

public class Milker : IVisitor
{
    private int milk = 0;


    public void GetMilk(int liters)
    {
        milk+=liters;
    }

    public int ShowMilk()
    {
        return milk;
    }
    
    public void visit(Cow animal)
    {
        Console.WriteLine($"{animal.GetType()} gave me 2 Litres of milk");
        GetMilk(2);
    }

    public void visit(Sheep animal)
    {
        Console.WriteLine($"{animal.GetType()} gave me 1 Litre of milk");
        GetMilk(1);
    }

    public void visit(Pig animal)
    {
        Console.WriteLine("Pig doesnt give milk");
    }

    public void visit(Chicken animal)
    {
        Console.WriteLine("Chicken doesnt give milk");
    }

    public void visit(Goat animal)
    {
        Console.WriteLine($"{animal.GetType()} gave me 3 Litres of milk");
        GetMilk(3);
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
        Console.WriteLine("There's no animal to milk in a Pen\n");
    }

    public void visit(Field field)
    {
        Console.WriteLine("I'm in a filed");
        foreach (var animals in field.GetList())
        {
            animals.accept(this);
        }
        Console.WriteLine("");
    }
}