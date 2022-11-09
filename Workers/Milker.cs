namespace Visitor_Pattern_SW4SWD.Workers;

public class Milker : IVisitor
{
    private int _milk = 0;

    public int ShowMilk()
    {
        return _milk;
    }
    
    public void visit(Cow cow)
    {
        int cowMilk = cow.Milk();
        Console.WriteLine($"Cow gave me {cowMilk} Litres of milk");
        _milk += cowMilk;
    }

    public void visit(Sheep sheep)
    {
        if (sheep.HasMilk())
        {
            int sheepMilk = sheep.Milk();
            Console.WriteLine($"Sheep gave me {sheepMilk} Litres of milk");
            _milk += sheepMilk;
        }
        else
        {
            Console.WriteLine("Sheep didn't have any milk");
        }
    }

    public void visit(Pig pig)
    {
        Console.WriteLine("Pig doesnt give milk");
    }

    public void visit(Chicken chicken)
    {
        Console.WriteLine("Chicken doesnt give milk");
    }

    public void visit(Goat goat)
    {
        if (goat.IsAngry())
        {
            Console.WriteLine("Auch! The goat headbutted me.");
        }
        else
        {
            int goatMilk = goat.Milk();
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