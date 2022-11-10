namespace Visitor_Pattern_SW4SWD.Workers;

public class Milker : IVisitor
{
    private int _milk = 0;

    public int ShowMilk()
    {
        return _milk;
    }
    
    public void visit(Cow animal)
    {
        int cowMilk = animal.Milk();
        Console.WriteLine($"Cow gave me {cowMilk} Litres of milk");
        _milk += cowMilk;
    }

    public void visit(Sheep animal)
    {
        if (animal.HasMilk())
        {
            int sheepMilk = animal.Milk();
            Console.WriteLine($"Sheep gave me {sheepMilk} Litres of milk");
            _milk += sheepMilk;
        }
        else
        {
            Console.WriteLine("Sheep didn't have any milk");
        }
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
        if (animal.IsAngry())
        {
            Console.WriteLine("Auch! The goat headbutted me.");
        }
        else
        {
            int goatMilk = animal.Milk();
            Console.WriteLine($"Goat gave me {goatMilk} Litres of milk");
            _milk += goatMilk;
        }
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
        Console.WriteLine("There's no animal to milk in a Pen\n");
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